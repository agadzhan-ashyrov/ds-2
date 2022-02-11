// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: job.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BackendApi {
  /// <summary>
  /// The job service definition.
  /// </summary>
  public static partial class Job
  {
    static readonly string __ServiceName = "job.Job";

    static readonly grpc::Marshaller<global::BackendApi.RegisterRequest> __Marshaller_job_RegisterRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BackendApi.RegisterRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BackendApi.RegisterResponse> __Marshaller_job_RegisterResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BackendApi.RegisterResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::BackendApi.RegisterRequest, global::BackendApi.RegisterResponse> __Method_Register = new grpc::Method<global::BackendApi.RegisterRequest, global::BackendApi.RegisterResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Register",
        __Marshaller_job_RegisterRequest,
        __Marshaller_job_RegisterResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BackendApi.JobReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Job</summary>
    public partial class JobClient : grpc::ClientBase<JobClient>
    {
      /// <summary>Creates a new client for Job</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public JobClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Job that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public JobClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected JobClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected JobClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Register job
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BackendApi.RegisterResponse Register(global::BackendApi.RegisterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Register(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Register job
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::BackendApi.RegisterResponse Register(global::BackendApi.RegisterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Register, null, options, request);
      }
      /// <summary>
      /// Register job
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BackendApi.RegisterResponse> RegisterAsync(global::BackendApi.RegisterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Register job
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::BackendApi.RegisterResponse> RegisterAsync(global::BackendApi.RegisterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Register, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override JobClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new JobClient(configuration);
      }
    }

  }
}
#endregion