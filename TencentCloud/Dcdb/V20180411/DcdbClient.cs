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

namespace TencentCloud.Dcdb.V20180411
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dcdb.V20180411.Models;

   public class DcdbClient : AbstractClient{

       private const string endpoint = "dcdb.tencentcloudapi.com";
       private const string version = "2018-04-11";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DcdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DcdbClient(Credential credential, string region, ClientProfile profile)
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
        /// 本接口（CreateDCDBInstance）用于创建包年包月的云数据库实例，可通过传入实例规格、数据库版本号、购买时长等信息创建云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateDCDBInstanceResponse"/>实例</returns>
        public async Task<CreateDCDBInstanceResponse> CreateDCDBInstance(CreateDCDBInstanceRequest req)
        {
             JsonResponseModel<CreateDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDCDBInstanceResponse>>(strResp);
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
        /// 本接口（DescribeDBSyncMode）用于查询云数据库实例的同步模式。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns>参考<see cref="DescribeDBSyncModeResponse"/>实例</returns>
        public async Task<DescribeDBSyncModeResponse> DescribeDBSyncMode(DescribeDBSyncModeRequest req)
        {
             JsonResponseModel<DescribeDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回10条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBInstancesResponse"/>实例</returns>
        public async Task<DescribeDCDBInstancesResponse> DescribeDCDBInstances(DescribeDCDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBPrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBPriceResponse"/>实例</returns>
        public async Task<DescribeDCDBPriceResponse> DescribeDCDBPrice(DescribeDCDBPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBRenewalPrice）用于在续费分布式数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBRenewalPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBRenewalPriceResponse"/>实例</returns>
        public async Task<DescribeDCDBRenewalPriceResponse> DescribeDCDBRenewalPrice(DescribeDCDBRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDCDBSaleInfo)用于查询分布式数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBSaleInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBSaleInfoResponse"/>实例</returns>
        public async Task<DescribeDCDBSaleInfoResponse> DescribeDCDBSaleInfo(DescribeDCDBSaleInfoRequest req)
        {
             JsonResponseModel<DescribeDCDBSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBShards）用于查询云数据库实例的分片信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBShardsResponse"/>实例</returns>
        public async Task<DescribeDCDBShardsResponse> DescribeDCDBShards(DescribeDCDBShardsRequest req)
        {
             JsonResponseModel<DescribeDCDBShardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBUpgradePrice）用于查询升级分布式数据库实例价格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDCDBUpgradePriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDCDBUpgradePriceResponse"/>实例</returns>
        public async Task<DescribeDCDBUpgradePriceResponse> DescribeDCDBUpgradePrice(DescribeDCDBUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeDCDBUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBUpgradePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabaseObjects）用于查询云数据库实例的数据库中的对象列表，包含表、存储过程、视图和函数。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns>参考<see cref="DescribeDatabaseObjectsResponse"/>实例</returns>
        public async Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
             JsonResponseModel<DescribeDatabaseObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabaseTable）用于查询云数据库实例的表信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns>参考<see cref="DescribeDatabaseTableResponse"/>实例</returns>
        public async Task<DescribeDatabaseTableResponse> DescribeDatabaseTable(DescribeDatabaseTableRequest req)
        {
             JsonResponseModel<DescribeDatabaseTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询云数据库实例的数据库列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDatabasesRequest"/></param>
        /// <returns>参考<see cref="DescribeDatabasesResponse"/>实例</returns>
        public async Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询分布式数据库订单信息。传入订单Id来查询订单关联的分布式数据库实例，和对应的任务流程ID。
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
        /// 查询可创建的分布式数据库可售卖的分片规格配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShardSpecRequest"/></param>
        /// <returns>参考<see cref="DescribeShardSpecResponse"/>实例</returns>
        public async Task<DescribeShardSpecResponse> DescribeShardSpec(DescribeShardSpecRequest req)
        {
             JsonResponseModel<DescribeShardSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShardSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShardSpecResponse>>(strResp);
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
        /// 本接口(InitDCDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req">参考<see cref="InitDCDBInstancesRequest"/></param>
        /// <returns>参考<see cref="InitDCDBInstancesResponse"/>实例</returns>
        public async Task<InitDCDBInstancesResponse> InitDCDBInstances(InitDCDBInstancesRequest req)
        {
             JsonResponseModel<InitDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDCDBInstancesResponse>>(strResp);
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
        /// 本接口（ModifyDBSyncMode）用于修改云数据库实例的同步模式。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns>参考<see cref="ModifyDBSyncModeResponse"/>实例</returns>
        public async Task<ModifyDBSyncModeResponse> ModifyDBSyncMode(ModifyDBSyncModeRequest req)
        {
             JsonResponseModel<ModifyDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBSyncModeResponse>>(strResp);
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
        /// 本接口（RenewDCDBInstance）用于续费分布式数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="RenewDCDBInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewDCDBInstanceResponse"/>实例</returns>
        public async Task<RenewDCDBInstanceResponse> RenewDCDBInstance(RenewDCDBInstanceRequest req)
        {
             JsonResponseModel<RenewDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDCDBInstanceResponse>>(strResp);
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
        /// 本接口（UpgradeDCDBInstance）用于升级分布式数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDCDBInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeDCDBInstanceResponse"/>实例</returns>
        public async Task<UpgradeDCDBInstanceResponse> UpgradeDCDBInstance(UpgradeDCDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
