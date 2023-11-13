// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcMantenance {
  public static partial class ProductIt
  {
    static readonly string __ServiceName = "productit.ProductIt";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.CreateProductRequest> __Marshaller_productit_CreateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.CreateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.CreateProductResponse> __Marshaller_productit_CreateProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.CreateProductResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.ReadProductRequest> __Marshaller_productit_ReadProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.ReadProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.ReadProductResponse> __Marshaller_productit_ReadProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.ReadProductResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.GetAllRequest> __Marshaller_productit_GetAllRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.GetAllRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.GetAllResponse> __Marshaller_productit_GetAllResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.GetAllResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.UpdateProductRequest> __Marshaller_productit_UpdateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.UpdateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.UpdateProductResponse> __Marshaller_productit_UpdateProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.UpdateProductResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.DeleteProductRequest> __Marshaller_productit_DeleteProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.DeleteProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcMantenance.DeleteProductResponse> __Marshaller_productit_DeleteProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcMantenance.DeleteProductResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMantenance.CreateProductRequest, global::GrpcMantenance.CreateProductResponse> __Method_Create = new grpc::Method<global::GrpcMantenance.CreateProductRequest, global::GrpcMantenance.CreateProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_productit_CreateProductRequest,
        __Marshaller_productit_CreateProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMantenance.ReadProductRequest, global::GrpcMantenance.ReadProductResponse> __Method_Read = new grpc::Method<global::GrpcMantenance.ReadProductRequest, global::GrpcMantenance.ReadProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Read",
        __Marshaller_productit_ReadProductRequest,
        __Marshaller_productit_ReadProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMantenance.GetAllRequest, global::GrpcMantenance.GetAllResponse> __Method_GetAll = new grpc::Method<global::GrpcMantenance.GetAllRequest, global::GrpcMantenance.GetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_productit_GetAllRequest,
        __Marshaller_productit_GetAllResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMantenance.UpdateProductRequest, global::GrpcMantenance.UpdateProductResponse> __Method_Update = new grpc::Method<global::GrpcMantenance.UpdateProductRequest, global::GrpcMantenance.UpdateProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_productit_UpdateProductRequest,
        __Marshaller_productit_UpdateProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcMantenance.DeleteProductRequest, global::GrpcMantenance.DeleteProductResponse> __Method_Delete = new grpc::Method<global::GrpcMantenance.DeleteProductRequest, global::GrpcMantenance.DeleteProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_productit_DeleteProductRequest,
        __Marshaller_productit_DeleteProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcMantenance.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductIt</summary>
    [grpc::BindServiceMethod(typeof(ProductIt), "BindService")]
    public abstract partial class ProductItBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMantenance.CreateProductResponse> Create(global::GrpcMantenance.CreateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMantenance.ReadProductResponse> Read(global::GrpcMantenance.ReadProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMantenance.GetAllResponse> GetAll(global::GrpcMantenance.GetAllRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMantenance.UpdateProductResponse> Update(global::GrpcMantenance.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcMantenance.DeleteProductResponse> Delete(global::GrpcMantenance.DeleteProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductItBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Read, serviceImpl.Read)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductItBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Create, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMantenance.CreateProductRequest, global::GrpcMantenance.CreateProductResponse>(serviceImpl.Create));
      serviceBinder.AddMethod(__Method_Read, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMantenance.ReadProductRequest, global::GrpcMantenance.ReadProductResponse>(serviceImpl.Read));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMantenance.GetAllRequest, global::GrpcMantenance.GetAllResponse>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMantenance.UpdateProductRequest, global::GrpcMantenance.UpdateProductResponse>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcMantenance.DeleteProductRequest, global::GrpcMantenance.DeleteProductResponse>(serviceImpl.Delete));
    }

  }
}
#endregion