/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Scf.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Scf.V20180416.Models;

   public class ScfClient : AbstractClient{

       private const string endpoint = "scf.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public ScfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public ScfClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 复制一个函数，您可以选择将复制出的新函数放置在特定的Region和Namespace。
        /// 注：本接口**不会**复制函数的以下对象或属性：
        /// 1. 函数的触发器
        /// 2. 除了$LATEST以外的其它版本
        /// 3. 函数配置的日志投递到的CLS目标。
        /// 
        /// 如有需要，您可以在复制后手动配置新函数。
        /// </summary>
        /// <param name="req">参考<see cref="CopyFunctionRequest"/></param>
        /// <returns>参考<see cref="CopyFunctionResponse"/>实例</returns>
        public async Task<CopyFunctionResponse> CopyFunction(CopyFunctionRequest req)
        {
             JsonResponseModel<CopyFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数创建新的函数。
        /// </summary>
        /// <param name="req">参考<see cref="CreateFunctionRequest"/></param>
        /// <returns>参考<see cref="CreateFunctionResponse"/>实例</returns>
        public async Task<CreateFunctionResponse> CreateFunction(CreateFunctionRequest req)
        {
             JsonResponseModel<CreateFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数创建命名空间。
        /// </summary>
        /// <param name="req">参考<see cref="CreateNamespaceRequest"/></param>
        /// <returns>参考<see cref="CreateNamespaceResponse"/>实例</returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据参数输入设置新的触发方式。
        /// </summary>
        /// <param name="req">参考<see cref="CreateTriggerRequest"/></param>
        /// <returns>参考<see cref="CreateTriggerResponse"/>实例</returns>
        public async Task<CreateTriggerResponse> CreateTrigger(CreateTriggerRequest req)
        {
             JsonResponseModel<CreateTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数删除函数。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFunctionRequest"/></param>
        /// <returns>参考<see cref="DeleteFunctionResponse"/>实例</returns>
        public async Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
             JsonResponseModel<DeleteFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数创建命名空间。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNamespaceRequest"/></param>
        /// <returns>参考<see cref="DeleteNamespaceResponse"/>实例</returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据参数传入删除已有的触发方式。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTriggerRequest"/></param>
        /// <returns>参考<see cref="DeleteTriggerResponse"/>实例</returns>
        public async Task<DeleteTriggerResponse> DeleteTrigger(DeleteTriggerRequest req)
        {
             JsonResponseModel<DeleteTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口获取某个函数的详细信息，包括名称、代码、处理方法、关联触发器和超时时间等字段。
        /// </summary>
        /// <param name="req">参考<see cref="GetFunctionRequest"/></param>
        /// <returns>参考<see cref="GetFunctionResponse"/>实例</returns>
        public async Task<GetFunctionResponse> GetFunction(GetFunctionRequest req)
        {
             JsonResponseModel<GetFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取函数代码包的下载地址。
        /// </summary>
        /// <param name="req">参考<see cref="GetFunctionAddressRequest"/></param>
        /// <returns>参考<see cref="GetFunctionAddressResponse"/>实例</returns>
        public async Task<GetFunctionAddressResponse> GetFunctionAddress(GetFunctionAddressRequest req)
        {
             JsonResponseModel<GetFunctionAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据指定的日志查询条件返回函数运行日志。
        /// </summary>
        /// <param name="req">参考<see cref="GetFunctionLogsRequest"/></param>
        /// <returns>参考<see cref="GetFunctionLogsResponse"/>实例</returns>
        public async Task<GetFunctionLogsResponse> GetFunctionLogs(GetFunctionLogsRequest req)
        {
             JsonResponseModel<GetFunctionLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于运行函数。
        /// </summary>
        /// <param name="req">参考<see cref="InvokeRequest"/></param>
        /// <returns>参考<see cref="InvokeResponse"/>实例</returns>
        public async Task<InvokeResponse> Invoke(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的查询参数返回相关函数信息。
        /// </summary>
        /// <param name="req">参考<see cref="ListFunctionsRequest"/></param>
        /// <returns>参考<see cref="ListFunctionsResponse"/>实例</returns>
        public async Task<ListFunctionsResponse> ListFunctions(ListFunctionsRequest req)
        {
             JsonResponseModel<ListFunctionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出命名空间列表
        /// </summary>
        /// <param name="req">参考<see cref="ListNamespacesRequest"/></param>
        /// <returns>参考<see cref="ListNamespacesResponse"/>实例</returns>
        public async Task<ListNamespacesResponse> ListNamespaces(ListNamespacesRequest req)
        {
             JsonResponseModel<ListNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数查询函数的版本。
        /// </summary>
        /// <param name="req">参考<see cref="ListVersionByFunctionRequest"/></param>
        /// <returns>参考<see cref="ListVersionByFunctionResponse"/>实例</returns>
        public async Task<ListVersionByFunctionResponse> ListVersionByFunction(ListVersionByFunctionRequest req)
        {
             JsonResponseModel<ListVersionByFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListVersionByFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListVersionByFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于用户发布新版本函数。
        /// </summary>
        /// <param name="req">参考<see cref="PublishVersionRequest"/></param>
        /// <returns>参考<see cref="PublishVersionResponse"/>实例</returns>
        public async Task<PublishVersionResponse> PublishVersion(PublishVersionRequest req)
        {
             JsonResponseModel<PublishVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数更新函数代码。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns>参考<see cref="UpdateFunctionCodeResponse"/>实例</returns>
        public async Task<UpdateFunctionCodeResponse> UpdateFunctionCode(UpdateFunctionCodeRequest req)
        {
             JsonResponseModel<UpdateFunctionCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数更新函数配置。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns>参考<see cref="UpdateFunctionConfigurationResponse"/>实例</returns>
        public async Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest req)
        {
             JsonResponseModel<UpdateFunctionConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新命名空间
        /// </summary>
        /// <param name="req">参考<see cref="UpdateNamespaceRequest"/></param>
        /// <returns>参考<see cref="UpdateNamespaceResponse"/>实例</returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespace(UpdateNamespaceRequest req)
        {
             JsonResponseModel<UpdateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
