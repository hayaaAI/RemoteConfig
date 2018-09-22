using Hayaa.BaseModel;
using Hayaa.BaseModel.Model;
using Hayaa.Common;
using Hayaa.CompanyWebSecurity.Client;
using Hayaa.RemoteConfig.Service;
using Hayaa.RemoteConfig.Service.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.RemoteConfigController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [UserAuthorityFilter]
    public class AppConfigController: ControllerBase
    {
        private IAppConfigService AppConfigService = new AppConfigServer();
        [HttpPost]
        [EnableCors("any")]
        [Desc("GetPager", "获取AppConfig分页列表", "根据appId获取AppConfig分页列表")]
        public TransactionResult<GridPager<AppConfig>> GetPager([FromForm] int page, [FromForm]  int size, [FromForm] int appId)
        {
            TransactionResult<GridPager<AppConfig>> result = new TransactionResult<GridPager<AppConfig>>(); 
            var serviceResult = AppConfigService.GetPager(new BaseModel.GridPagerPamater<AppConfigSearchPamater>()
            {
                Current = page,
                PageSize = size,
                SearchPamater = new AppConfigSearchPamater() { AppId=appId }
            });
            if (serviceResult.ActionResult )
            {
                if (serviceResult.HavingData)
                    result.Data = serviceResult;
                else
                    result.Data = new GridPager<AppConfig>() { Data=new List<AppConfig>() };
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = "暂无数据";
            }
            return result;
        }
        [HttpPost]
        [EnableCors("any")]
        [Desc("Get", "获取AppConfig", "根据主键获取数据")]
        public TransactionResult<AppConfig> Get([FromForm] int id)
        {
            TransactionResult<AppConfig> result = new TransactionResult<AppConfig>();
            var serviceResult = AppConfigService.Get(id);
            if (serviceResult.ActionResult & serviceResult.HavingData)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = "暂无数据";
            }
            return result;
        }
        [HttpPost]
        [EnableCors("any")]
        [Desc("Add", "添加AppConfig", "")]
        public TransactionResult<AppConfig> Add([FromForm] AppConfig info)
        {
            TransactionResult<AppConfig> result = new TransactionResult<AppConfig>();

            var serviceResult = AppConfigService.Create(info);

            if (serviceResult.ActionResult & serviceResult.HavingData)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = "暂无数据";
            }
            return result;
        }
        [HttpPost]
        [EnableCors("any")]
        [Desc("Edit", "更新AppConfig", "根据主键更新数据")]
        public TransactionResult<Boolean> Edit([FromForm] AppConfig info)
        {
            TransactionResult<Boolean> result = new TransactionResult<Boolean>();
            var serviceResult = AppConfigService.UpdateByID(info);
            if (serviceResult.ActionResult)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = "暂无数据";
            }
            return result;
        }
        [HttpPost]
        [EnableCors("any")]
        [Desc("Delete", "删除AppConfig", "根据主键删除数据")]
        public TransactionResult<Boolean> Delete([FromForm] int id)
        {
            TransactionResult<Boolean> result = new TransactionResult<Boolean>();
            var serviceResult = AppConfigService.DeleteByID(new List<int>() { id });
            if (serviceResult.ActionResult)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = "暂无数据";
            }
            return result;
        }
        [HttpPost]
        [EnableCors("any")]
        [Desc("AddComponentConfig", "添加组件配置", "")]
        public TransactionResult<Boolean> AddComponentConfig([FromForm] int appConfigId, [FromForm]  int componentConfigId)
        {
            TransactionResult<Boolean> result = new TransactionResult<Boolean>();
            var serviceResult = AppConfigService.AddComponentConfigForApp(componentConfigId, appConfigId);
            if (serviceResult.ActionResult&&serviceResult.Data)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = serviceResult.ErrorMsg;
            }
            return result;
        }
        [HttpPost]
        [EnableCors("any")]
        [Desc("RemoveComponentConfig", "移除组件配置", "")]
        public TransactionResult<Boolean> RemoveComponentConfig([FromForm] int appConfigId, [FromForm]  int componentConfigId)
        {
            TransactionResult<Boolean> result = new TransactionResult<Boolean>();
            var serviceResult = AppConfigService.RemoveComponentConfigForApp(new List<int>() { componentConfigId }, appConfigId);
            if (serviceResult.ActionResult && serviceResult.Data)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = ErrorCode.NoData;
                result.Message = serviceResult.ErrorMsg;
            }
            return result;
        }       
    }
}
