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

namespace TencentCloud.Mariadb.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mariadb.V20170312.Models;

   public class MariadbClient : AbstractClient{

       private const string endpoint = "mariadb.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public MariadbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public MariadbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CloneAccount）用于克隆实例账户。
        /// </summary>
        /// <param name="req">参考<see cref="CloneAccountRequest"/></param>
        /// <returns>参考<see cref="CloneAccountResponse"/>实例</returns>
        public async Task<CloneAccountResponse> CloneAccount(CloneAccountRequest req)
        {
             JsonResponseModel<CloneAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CloseDBExtranetAccess)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问，查询实例列表接口将不返回对应实例的外网域名和端口信息。
        /// </summary>
        /// <param name="req">参考<see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns>参考<see cref="CloseDBExtranetAccessResponse"/>实例</returns>
        public async Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CopyAccountPrivileges）用于复制云数据库账号的权限。
        /// 注意：相同用户名，不同Host是不同的账号，Readonly属性相同的账号之间才能复制权限。
        /// </summary>
        /// <param name="req">参考<see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns>参考<see cref="CopyAccountPrivilegesResponse"/>实例</returns>
        public async Task<CopyAccountPrivilegesResponse> CopyAccountPrivileges(CopyAccountPrivilegesRequest req)
        {
             JsonResponseModel<CopyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建云数据库账号。一个实例可以创建多个不同的账号，相同的用户名+不同的host是不同的账号。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccountRequest"/></param>
        /// <returns>参考<see cref="CreateAccountResponse"/>实例</returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstance）用于创建包年包月的云数据库实例，可通过传入实例规格、数据库版本号、购买时长和数量等信息创建云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateDBInstanceResponse"/>实例</returns>
        public async Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除云数据库账号。用户名+host唯一确定一个账号。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAccountRequest"/></param>
        /// <returns>参考<see cref="DeleteAccountResponse"/>实例</returns>
        public async Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccountPrivileges）用于查询云数据库账号权限。
        /// 注意：注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountPrivilegesResponse"/>实例</returns>
        public async Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于查询指定云数据库实例的账号列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountsResponse"/>实例</returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupTime）用于获取云数据库的备份时间。后台系统将根据此配置定期进行实例备份。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupTimeRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupTimeResponse"/>实例</returns>
        public async Task<DescribeBackupTimeResponse> DescribeBackupTime(DescribeBackupTimeRequest req)
        {
             JsonResponseModel<DescribeBackupTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceSpecs)用于查询可创建的云数据库可售卖的规格配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstanceSpecsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstanceSpecsResponse"/>实例</returns>
        public async Task<DescribeDBInstanceSpecsResponse> DescribeDBInstanceSpecs(DescribeDBInstanceSpecsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSpecsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBInstances）用于查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回20条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstancesResponse"/>实例</returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBLogFiles)用于获取数据库的各种日志列表，包括冷备、binlog、errlog和slowlog。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns>参考<see cref="DescribeDBLogFilesResponse"/>实例</returns>
        public async Task<DescribeDBLogFilesResponse> DescribeDBLogFiles(DescribeDBLogFilesRequest req)
        {
             JsonResponseModel<DescribeDBLogFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBLogFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBLogFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBParameters)用于获取数据库的当前参数设置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBParametersRequest"/></param>
        /// <returns>参考<see cref="DescribeDBParametersResponse"/>实例</returns>
        public async Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
             JsonResponseModel<DescribeDBParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBPerformance)用于查看数据库实例当前性能数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBPerformanceRequest"/></param>
        /// <returns>参考<see cref="DescribeDBPerformanceResponse"/>实例</returns>
        public async Task<DescribeDBPerformanceResponse> DescribeDBPerformance(DescribeDBPerformanceRequest req)
        {
             JsonResponseModel<DescribeDBPerformanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBPerformance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBPerformanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBPerformanceDetails)用于查看实例性能数据详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBPerformanceDetailsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBPerformanceDetailsResponse"/>实例</returns>
        public async Task<DescribeDBPerformanceDetailsResponse> DescribeDBPerformanceDetails(DescribeDBPerformanceDetailsRequest req)
        {
             JsonResponseModel<DescribeDBPerformanceDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBPerformanceDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBPerformanceDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBResourceUsage)用于查看数据库实例资源的使用情况。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBResourceUsageRequest"/></param>
        /// <returns>参考<see cref="DescribeDBResourceUsageResponse"/>实例</returns>
        public async Task<DescribeDBResourceUsageResponse> DescribeDBResourceUsage(DescribeDBResourceUsageRequest req)
        {
             JsonResponseModel<DescribeDBResourceUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBResourceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBResourceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBResourceUsageDetails)用于查看数据库实例当前性能数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBResourceUsageDetailsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBResourceUsageDetailsResponse"/>实例</returns>
        public async Task<DescribeDBResourceUsageDetailsResponse> DescribeDBResourceUsageDetails(DescribeDBResourceUsageDetailsRequest req)
        {
             JsonResponseModel<DescribeDBResourceUsageDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBResourceUsageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBResourceUsageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSlowLogs)用于查询慢查询日志列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBSlowLogsResponse"/>实例</returns>
        public async Task<DescribeDBSlowLogsResponse> DescribeDBSlowLogs(DescribeDBSlowLogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询流程状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFlowRequest"/></param>
        /// <returns>参考<see cref="DescribeFlowResponse"/>实例</returns>
        public async Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
             JsonResponseModel<DescribeFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeLogFileRetentionPeriod)用于查看数据库备份日志的备份天数的设置情况。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns>参考<see cref="DescribeLogFileRetentionPeriodResponse"/>实例</returns>
        public async Task<DescribeLogFileRetentionPeriodResponse> DescribeLogFileRetentionPeriod(DescribeLogFileRetentionPeriodRequest req)
        {
             JsonResponseModel<DescribeLogFileRetentionPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogFileRetentionPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogFileRetentionPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询云数据库订单信息。传入订单Id来查询订单关联的云数据库实例，和对应的任务流程ID。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOrdersRequest"/></param>
        /// <returns>参考<see cref="DescribeOrdersResponse"/>实例</returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePriceRequest"/></param>
        /// <returns>参考<see cref="DescribePriceResponse"/>实例</returns>
        public async Task<DescribePriceResponse> DescribePrice(DescribePriceRequest req)
        {
             JsonResponseModel<DescribePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRenewalPrice）用于在续费云数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRenewalPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeRenewalPriceResponse"/>实例</returns>
        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPrice(DescribeRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSaleInfo)用于查询云数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSaleInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeSaleInfoResponse"/>实例</returns>
        public async Task<DescribeSaleInfoResponse> DescribeSaleInfo(DescribeSaleInfoRequest req)
        {
             JsonResponseModel<DescribeSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSqlLogs）用于获取实例SQL日志。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSqlLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeSqlLogsResponse"/>实例</returns>
        public async Task<DescribeSqlLogsResponse> DescribeSqlLogs(DescribeSqlLogsRequest req)
        {
             JsonResponseModel<DescribeSqlLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSqlLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSqlLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUpgradePrice）用于在扩容云数据库实例时，查询扩容的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUpgradePriceRequest"/></param>
        /// <returns>参考<see cref="DescribeUpgradePriceResponse"/>实例</returns>
        public async Task<DescribeUpgradePriceResponse> DescribeUpgradePrice(DescribeUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUpgradePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GrantAccountPrivileges）用于给云数据库账号赋权。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req">参考<see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns>参考<see cref="GrantAccountPrivilegesResponse"/>实例</returns>
        public async Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
             JsonResponseModel<GrantAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GrantAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(InitDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req">参考<see cref="InitDBInstancesRequest"/></param>
        /// <returns>参考<see cref="InitDBInstancesResponse"/>实例</returns>
        public async Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountDescription）用于修改云数据库账号备注。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns>参考<see cref="ModifyAccountDescriptionResponse"/>实例</returns>
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupTime）用于设置云数据库实例的备份时间。后台系统将根据此配置定期进行实例备份。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyBackupTimeRequest"/></param>
        /// <returns>参考<see cref="ModifyBackupTimeResponse"/>实例</returns>
        public async Task<ModifyBackupTimeResponse> ModifyBackupTime(ModifyBackupTimeRequest req)
        {
             JsonResponseModel<ModifyBackupTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceNameResponse"/>实例</returns>
        public async Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstancesProject）用于修改云数据库实例所属项目。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstancesProjectResponse"/>实例</returns>
        public async Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBParameters)用于修改数据库参数。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBParametersRequest"/></param>
        /// <returns>参考<see cref="ModifyDBParametersResponse"/>实例</returns>
        public async Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
             JsonResponseModel<ModifyDBParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyLogFileRetentionPeriod)用于修改数据库备份日志保存天数。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLogFileRetentionPeriodRequest"/></param>
        /// <returns>参考<see cref="ModifyLogFileRetentionPeriodResponse"/>实例</returns>
        public async Task<ModifyLogFileRetentionPeriodResponse> ModifyLogFileRetentionPeriod(ModifyLogFileRetentionPeriodRequest req)
        {
             JsonResponseModel<ModifyLogFileRetentionPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogFileRetentionPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogFileRetentionPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通云数据库实例的外网访问。开通外网访问后，您可通过外网域名和端口访问实例，可使用查询实例列表接口获取外网域名和端口信息。
        /// </summary>
        /// <param name="req">参考<see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns>参考<see cref="OpenDBExtranetAccessResponse"/>实例</returns>
        public async Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDBInstance）用于续费云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="RenewDBInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewDBInstanceResponse"/>实例</returns>
        public async Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置云数据库账号的密码。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req">参考<see cref="ResetAccountPasswordRequest"/></param>
        /// <returns>参考<see cref="ResetAccountPasswordResponse"/>实例</returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpgradeDBInstance)用于扩容云数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeDBInstanceResponse"/>实例</returns>
        public async Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
