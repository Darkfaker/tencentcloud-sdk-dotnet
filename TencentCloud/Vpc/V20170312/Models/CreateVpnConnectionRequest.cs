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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVpnConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。可通过DescribeVpcs接口返回值中的VpcId获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPN网关实例ID。
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// 对端网关ID，例如：cgw-2wqq41m9，可通过DescribeCustomerGateways接口查询对端网关。
        /// </summary>
        [JsonProperty("CustomerGatewayId")]
        public string CustomerGatewayId{ get; set; }

        /// <summary>
        /// 通道名称，可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("VpnConnectionName")]
        public string VpnConnectionName{ get; set; }

        /// <summary>
        /// 预共享密钥。
        /// </summary>
        [JsonProperty("PreShareKey")]
        public string PreShareKey{ get; set; }

        /// <summary>
        /// SPD策略组，例如：{"10.0.0.5/24":["172.123.10.5/16"]}，10.0.0.5/24是vpc内网段172.123.10.5/16是IDC网段。用户指定VPC内哪些网段可以和您IDC中哪些网段通信。
        /// </summary>
        [JsonProperty("SecurityPolicyDatabases")]
        public SecurityPolicyDatabase[] SecurityPolicyDatabases{ get; set; }

        /// <summary>
        /// IKE配置（Internet Key Exchange，因特网密钥交换），IKE具有一套自我保护机制，用户配置网络安全协议
        /// </summary>
        [JsonProperty("IKEOptionsSpecification")]
        public IKEOptionsSpecification IKEOptionsSpecification{ get; set; }

        /// <summary>
        /// IPSec配置，腾讯云提供IPSec安全会话设置
        /// </summary>
        [JsonProperty("IPSECOptionsSpecification")]
        public IPSECOptionsSpecification IPSECOptionsSpecification{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "CustomerGatewayId", this.CustomerGatewayId);
            this.SetParamSimple(map, prefix + "VpnConnectionName", this.VpnConnectionName);
            this.SetParamSimple(map, prefix + "PreShareKey", this.PreShareKey);
            this.SetParamArrayObj(map, prefix + "SecurityPolicyDatabases.", this.SecurityPolicyDatabases);
            this.SetParamObj(map, prefix + "IKEOptionsSpecification.", this.IKEOptionsSpecification);
            this.SetParamObj(map, prefix + "IPSECOptionsSpecification.", this.IPSECOptionsSpecification);
        }
    }
}

