const evn="dev";
const  baseUrl={
    remoteconfig:"http://"+evn+".remoteconfig.xieqj.net/",
    serviceframe:"http://"+evn+".serviceframe.xieqj.net/",
    security:"http://"+evn+".security.xieqj.net/",
    autocode:"http://"+evn+".code.xieqj.net/"
}
const urls={
    authUrl:baseUrl.security+"api/login/IsLogin",
    loginUrl:baseUrl.security+"api/login/Login",
    appPagerUrl:baseUrl.remoteconfig+"api/mananger/GetAppPager",
    appGetUrl:baseUrl.remoteconfig+"api/mananger/GetApp",
    appAddUrl:baseUrl.remoteconfig+"api/mananger/AddApp",
    appEditUrl:baseUrl.remoteconfig+"api/mananger/EditApp",
    appDeleteUrl:baseUrl.remoteconfig+"api/mananger/DeleteApp",
    componentPagerUrl:baseUrl.remoteconfig+"api/mananger/GetComponentPager",
    componentGetUrl:baseUrl.remoteconfig+"api/mananger/GetComponent",
    componentAddUrl:baseUrl.remoteconfig+"api/mananger/AddComponent",
    componentEditUrl:baseUrl.remoteconfig+"api/mananger/EditComponent",
    componentDeleteUrl:baseUrl.remoteconfig+"api/mananger/DeleteComponent",
    appConfigPagerUrl:baseUrl.remoteconfig+"api/appconfig/GetPager",
    appConfigGetUrl:baseUrl.remoteconfig+"api/appconfig/Get",
    appConfigAddUrl:baseUrl.remoteconfig+"api/appconfig/Add",
    appConfigEditUrl:baseUrl.remoteconfig+"api/appconfig/Edit",
    appConfigDeleteUrl:baseUrl.remoteconfig+"api/appconfig/Delete",
    appConfigAddComponentConfigUrl:baseUrl.remoteconfig+"api/appconfig/AddComponentConfig",
    appConfigDeleteComponentConfigUrl:baseUrl.remoteconfig+"api/appconfig/RemoveComponentConfig",
    appConfigDelete10002ComponentConfigUrl:baseUrl.remoteconfig+"api/appconfig/Remove10002ComponentConfig",
    componentConfigPagerUrl:baseUrl.remoteconfig+"api/componentconfig/GetPager",
    componentConfigGetUrl:baseUrl.remoteconfig+"api/componentconfig/Get",
    componentConfigGetListUrl:baseUrl.remoteconfig+"api/componentconfig/GetList",
    componentConfigAddUrl:baseUrl.remoteconfig+"api/componentconfig/Add",
    componentConfigEditUrl:baseUrl.remoteconfig+"api/componentconfig/Edit",
    componentConfigDeleteUrl:baseUrl.remoteconfig+"api/componentconfig/Delete",
    appUserPagerUrl:baseUrl.serviceframe+"api/appuser/GetAppUserPager",
    appUserGetUrl:baseUrl.serviceframe+"api/appuser/GetAppUser",
    appUserAddUrl:baseUrl.serviceframe+"api/appuser/AddAppUser",
    appUserEditUrl:baseUrl.serviceframe+"api/appuser/EditAppUser",
    appUserDeleteUrl:baseUrl.remoteconfig+"api/appuser/DeleteAppUser",
    appComponentFactoryCreateUrl:baseUrl.serviceframe+"api/appcomponent/CreateFactoryConfig",
    appComponentPagerUrl:baseUrl.serviceframe+"api/appcomponent/GetAppComponentPager",
    appComponentGetUrl:baseUrl.serviceframe+"api/appcomponent/GetAppComponent",
    appComponentGetListUrl:baseUrl.serviceframe+"api/appcomponent/GetAppComponentList",
    appComponentAddUrl:baseUrl.serviceframe+"api/appcomponent/AddAppComponent",
    appComponentEditUrl:baseUrl.serviceframe+"api/appcomponent/EditAppComponent",
    appComponentDeleteUrl:baseUrl.serviceframe+"api/appcomponent/DeleteAppComponent",
    codeSolutionGetUrl:baseUrl.autocode+"api/solutiontemplate/Get",
    codeSolutionGetListUrl:baseUrl.autocode+"api/solutiontemplate/GetPager",
    codeSolutionAddUrl:baseUrl.autocode+"api/solutiontemplate/Add",
    codeSolutionEditUrl:baseUrl.autocode+"api/solutiontemplate/Edit",
    codeSolutionDeleteUrl:baseUrl.autocode+"api/solutiontemplate/Delete",
    codeGenUrl:baseUrl.autocode+"api/solutiontemplate/GenCode",
    codeGetFileUrl:baseUrl.autocode,
    codeTemplateGetUrl:baseUrl.autocode+"api/solutiontemplate/GetCodeTemplate",
    codeTemplateGetListUrl:baseUrl.autocode+"api/solutiontemplate/GetCodeTemplateList",
    codeTemplateAddUrl:baseUrl.autocode+"api/solutiontemplate/AddCodeTemplate",
    codeTemplateEditUrl:baseUrl.autocode+"api/solutiontemplate/EditCodeTemplate",
    codeTemplateDeleteUrl:baseUrl.autocode+"api/solutiontemplate/DeleteCodeTemplate"
}
export default urls