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

namespace TencentCloud.Emr.V20190103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Emr.V20190103.Models;

   public class EmrClient : AbstractClient{

       private const string endpoint = "emr.tencentcloudapi.com";
       private const string version = "2019-01-03";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public EmrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public EmrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建EMR实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateInstanceResponse"/>实例</returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询EMR实例
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesResponse"/>实例</returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例询价
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceCreateInstanceResponse"/>实例</returns>
        public async Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费询价。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceRenewInstanceResponse"/>实例</returns>
        public async Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩容询价. 当扩容时候，请通过该接口查询价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceScaleOutInstanceResponse"/>实例</returns>
        public async Task<InquiryPriceScaleOutInstanceResponse> InquiryPriceScaleOutInstance(InquiryPriceScaleOutInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变配询价
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceUpdateInstanceResponse"/>实例</returns>
        public async Task<InquiryPriceUpdateInstanceResponse> InquiryPriceUpdateInstance(InquiryPriceUpdateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例扩容
        /// </summary>
        /// <param name="req">参考<see cref="ScaleOutInstanceRequest"/></param>
        /// <returns>参考<see cref="ScaleOutInstanceResponse"/>实例</returns>
        public async Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁EMR实例
        /// </summary>
        /// <param name="req">参考<see cref="TerminateInstanceRequest"/></param>
        /// <returns>参考<see cref="TerminateInstanceResponse"/>实例</returns>
        public async Task<TerminateInstanceResponse> TerminateInstance(TerminateInstanceRequest req)
        {
             JsonResponseModel<TerminateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 缩容Task节点
        /// </summary>
        /// <param name="req">参考<see cref="TerminateTasksRequest"/></param>
        /// <returns>参考<see cref="TerminateTasksResponse"/>实例</returns>
        public async Task<TerminateTasksResponse> TerminateTasks(TerminateTasksRequest req)
        {
             JsonResponseModel<TerminateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
