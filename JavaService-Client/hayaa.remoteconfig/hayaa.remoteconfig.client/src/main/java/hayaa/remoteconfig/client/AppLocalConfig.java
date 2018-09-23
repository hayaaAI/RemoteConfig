package hayaa.remoteconfig.client;


import hayaa.rpc.common.config.RpcConfig;

public class AppLocalConfig {
    private String seedServerUrl;
    private String localConfigDirectoryPath;
    private Boolean virtualPath;
    private String securityToken;
    private int appID;
    private int appInstanceID;
    private String appConfigSolutionID;
    private Integer version;
    private Boolean eemote;
    private String appConfigFileName;
    private Boolean remoteConfigRoot;
    private int remoteType;
    private RpcConfig rpcRemoteServiceConfig;

    public String getSeedServerUrl() {
        return seedServerUrl;
    }

    public void setSeedServerUrl(String seedServerUrl) {
        this.seedServerUrl = seedServerUrl;
    }

    public String getLocalConfigDirectoryPath() {
        return localConfigDirectoryPath;
    }

    public void setLocalConfigDirectoryPath(String localConfigDirectoryPath) {
        this.localConfigDirectoryPath = localConfigDirectoryPath;
    }

    public Boolean getVirtualPath() {
        return virtualPath;
    }

    public void setVirtualPath(Boolean virtualPath) {
        this.virtualPath = virtualPath;
    }

    public String getSecurityToken() {
        return securityToken;
    }

    public void setSecurityToken(String securityToken) {
        this.securityToken = securityToken;
    }

    public int getAppID() {
        return appID;
    }

    public void setAppID(int appID) {
        this.appID = appID;
    }

    public int getAppInstanceID() {
        return appInstanceID;
    }

    public void setAppInstanceID(int appInstanceID) {
        this.appInstanceID = appInstanceID;
    }

    public String getAppConfigSolutionID() {
        return appConfigSolutionID;
    }

    public void setAppConfigSolutionID(String appConfigSolutionID) {
        this.appConfigSolutionID = appConfigSolutionID;
    }

    public Integer getVersion() {
        return version;
    }

    public void setVersion(Integer version) {
        this.version = version;
    }

    public Boolean getEemote() {
        return eemote;
    }

    public void setEemote(Boolean eemote) {
        this.eemote = eemote;
    }

    public String getAppConfigFileName() {
        return appConfigFileName;
    }

    public void setAppConfigFileName(String appConfigFileName) {
        this.appConfigFileName = appConfigFileName;
    }

    public Boolean getRemoteConfigRoot() {
        return remoteConfigRoot;
    }

    public void setRemoteConfigRoot(Boolean remoteConfigRoot) {
        this.remoteConfigRoot = remoteConfigRoot;
    }

    public int getRemoteType() {
        return remoteType;
    }

    public void setRemoteType(int remoteType) {
        this.remoteType = remoteType;
    }

    public RpcConfig getRpcRemoteServiceConfig() {
        return rpcRemoteServiceConfig;
    }

    public void setRpcRemoteServiceConfig(RpcConfig rpcRemoteServiceConfig) {
        this.rpcRemoteServiceConfig = rpcRemoteServiceConfig;
    }
}
