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

namespace TencentCloud.Domain.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Domain.V20180808.Models;

   public class DomainClient : AbstractClient{

       private const string endpoint = "domain.tencentcloudapi.com";
       private const string version = "2018-08-08";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DomainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DomainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 检查域名是否可以注册
        /// </summary>
        /// <param name="req">参考<see cref="CheckDomainRequest"/></param>
        /// <returns>参考<see cref="CheckDomainResponse"/>实例</returns>
        public async Task<CheckDomainResponse> CheckDomain(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns>参考<see cref="DescribeDomainPriceListResponse"/>实例</returns>
        public async Task<DescribeDomainPriceListResponse> DescribeDomainPriceList(DescribeDomainPriceListRequest req)
        {
             JsonResponseModel<DescribeDomainPriceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainPriceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPriceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
