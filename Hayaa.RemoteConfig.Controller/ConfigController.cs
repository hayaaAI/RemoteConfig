﻿using Hayaa.BaseModel.Model;
using Hayaa.RemoteConfig.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hayaa.RemoteConfigController
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private IRemoteConfigService service = new RemoteConfigServer();
        //[HttpPost]
        //[HttpGet]
        //[Desc("SendConfig", "获取远程配置服务", "")]
        //public TransactionResult<AppConfig> SendConfig(String sid, int v)
        //{
        //    TransactionResult<AppConfig> result = new TransactionResult<AppConfig>();
        //    var serviceResult = service.SendConfig(sid, v);
        //    if (serviceResult.ActionResult & serviceResult.HavingData)
        //    {
        //        result.Data = serviceResult.Data;
        //    }
        //    return result;
        //}
        [HttpPost]
        [HttpGet]
        [EnableCors("any")]
        [Desc("SendJsAppConfig", "获取js配置服务", "")]
        public TransactionResult<String> SendJsAppConfig([FromForm] String sid, [FromForm] int v)
        {
            TransactionResult<String> result = new TransactionResult<String>();
            var serviceResult = service.SendJsAppConfig(sid, v);
            if (serviceResult.ActionResult & serviceResult.HavingData)
            {
                result.Data = serviceResult.Data.ConfigContent;
            }
            return result;
        }
    }
}
