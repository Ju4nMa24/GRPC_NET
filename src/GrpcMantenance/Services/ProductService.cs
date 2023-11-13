using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcMantenance.Data;
using GrpcMantenance.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcMantenance.Services
{
    public class ProductService : ProductIt.ProductItBase
    {
        private readonly GrpcDbContext _db;

        public ProductService(GrpcDbContext db)
        {
            _db = db;
        }
        public override async Task<ReadProductResponse> Read(ReadProductRequest request, ServerCallContext context)
        {
            if (request.Id < 1)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "El indice del producto debe ser mayor que cero"));

            Product? product = await _db.Products.FirstOrDefaultAsync(p => p.Id == request.Id);
            if (product is not null)
            {
                return await Task.FromResult(new ReadProductResponse
                {
                    Id = product.Id,
                    Description = product.Description ?? string.Empty,
                    Name = product.Name ?? string.Empty,
                    Status = product.Status ?? string.Empty
                });
            }

            throw new RpcException(new Status(StatusCode.NotFound, $"No se encontro el producto con el id: {request.Id}"));
        }


        public override async Task<CreateProductResponse> Create(CreateProductRequest request, ServerCallContext context)
        {
            if (request is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Validar la informacion suministrada"));

            Product? product = new()
            {
                Name = request.Name,
                Description = request.Description
            };
            await _db.AddAsync(product);
            await _db.SaveChangesAsync();
            return await Task.FromResult(new CreateProductResponse
            {
                Id = product.Id
            });
        }

        public override async Task<GetAllResponse> GetAll(GetAllRequest request, ServerCallContext context)
        {
            List<Product>? products = await _db.Products.ToListAsync();
            GetAllResponse result = new();
            foreach (Product product in products)
            {
                result.Products.Add(new ReadProductResponse
                {
                    Id = product.Id,
                    Description = product.Description ?? string.Empty,
                    Name = product.Name ?? string.Empty,
                    Status = product.Status ?? string.Empty
                });
            }
            return await Task.FromResult(result);
        }

        public override async Task<DeleteProductResponse> Delete(DeleteProductRequest request, ServerCallContext context)
        {
            if (request is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Validar la informacion suministrada"));

            Product? product = await _db.Products.FirstOrDefaultAsync(p => p.Id == request.Id);

            if (product is null)
                throw new RpcException(new Status(StatusCode.NotFound, $"No se encontro el producto con el id: {request.Id}"));

            #region Product
            _db.Remove(product);
            await _db.SaveChangesAsync();
            #endregion
            return await Task.FromResult(new DeleteProductResponse{
                Id = request.Id
            });
        }

        public override async Task<UpdateProductResponse> Update(UpdateProductRequest request, ServerCallContext context)
        {
            if (request is null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Validar la informacion suministrada"));

            Product? product = await _db.Products.FirstOrDefaultAsync(p => p.Id == request.Id);

            if (product is null)
                throw new RpcException(new Status(StatusCode.NotFound, $"No se encontro el producto con el id: {request.Id}"));

            #region Product
            product.Name = request.Name ?? product.Name;
            product.Description = request.Description ?? product.Description;
            product.Status = request.Status ?? product.Status;
            #endregion

            await _db.SaveChangesAsync();
            return await Task.FromResult(new UpdateProductResponse
            {
                Id = product.Id
            });
        }
    }
}