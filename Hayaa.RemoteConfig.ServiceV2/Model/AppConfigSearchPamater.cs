using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
namespace Hayaa.RemoteConfig.Service.Model
{
    public class AppConfigSearchPamater : SearchPamaterMariadbBase
    {
        public int? AppConfigId { set; get; }
        public List<int> AppConfigIdList { set; get; }
        public int? AppConfigIdMax { set; get; }
        public int? AppConfigIdMin { set; get; }
        public void SetAppConfigId(int? max, int? min) { this.AppConfigIdMax = max; this.AppConfigIdMin = min; this.AppConfigIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppConfigIdPOT;
        public void SetAppConfigId(int? info, PamaterOperationType pot) { this.AppConfigId = info; this.AppConfigIdPOT = pot; }
        private String GetAppConfigIdSqlForSharp()
        {
            String sql = ""; switch (AppConfigIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppConfigId between @AppConfigIdMin to @AppConfigIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppConfigId like '%@AppConfigId%'"; break;
                case PamaterOperationType.Equal: sql = "AppConfigId=@AppConfigId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppConfigId>=@AppConfigId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppConfigId>@AppConfigId"; break;
                case PamaterOperationType.LessEqual: sql = "AppConfigId<=@AppConfigId"; break;
                case PamaterOperationType.LessThan: sql = "AppConfigId<=@AppConfigId"; break;
                case PamaterOperationType.In: sql = "AppConfigId in(" + String.Join(",", this.AppConfigIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppConfigId in('" + String.Join("','", this.AppConfigIdList) + "')"; break;
            }
            return sql;
        }
        public int? AppId { set; get; }
        public List<int> AppIdList { set; get; }
        public int? AppIdMax { set; get; }
        public int? AppIdMin { set; get; }
        public void SetAppId(int? max, int? min) { this.AppIdMax = max; this.AppIdMin = min; this.AppIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppIdPOT;
        public void SetAppId(int? info, PamaterOperationType pot) { this.AppId = info; this.AppIdPOT = pot; }
        private String GetAppIdSqlForSharp()
        {
            String sql = ""; switch (AppIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppId between @AppIdMin to @AppIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppId like '%@AppId%'"; break;
                case PamaterOperationType.Equal: sql = "AppId=@AppId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppId>=@AppId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppId>@AppId"; break;
                case PamaterOperationType.LessEqual: sql = "AppId<=@AppId"; break;
                case PamaterOperationType.LessThan: sql = "AppId<=@AppId"; break;
                case PamaterOperationType.In: sql = "AppId in(" + String.Join(",", this.AppIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppId in('" + String.Join("','", this.AppIdList) + "')"; break;
            }
            return sql;
        }
        public String SolutionID { set; get; }
        public List<String> SolutionIDList { set; get; }
        private PamaterOperationType SolutionIDPOT;
        public void SetSolutionID(String info, PamaterOperationType pot) { this.SolutionID = info; this.SolutionIDPOT = pot; }
        private String GetSolutionIDSqlForSharp()
        {
            String sql = ""; switch (SolutionIDPOT)
            {
                case PamaterOperationType.StringContains: sql = "SolutionID like '%@SolutionID%'"; break;
                case PamaterOperationType.Equal: sql = "SolutionID=@SolutionID"; break;
                case PamaterOperationType.GreaterEqual: sql = "SolutionID>=@SolutionID"; break;
                case PamaterOperationType.GreaterThan: sql = "SolutionID>@SolutionID"; break;
                case PamaterOperationType.LessEqual: sql = "SolutionID<=@SolutionID"; break;
                case PamaterOperationType.LessThan: sql = "SolutionID<=@SolutionID"; break;
                case PamaterOperationType.In: sql = "SolutionID in(" + String.Join(",", this.SolutionIDList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "SolutionID in('" + String.Join("','", this.SolutionIDList) + "')"; break;
            }
            return sql;
        }
        public String SolutionName { set; get; }
        public List<String> SolutionNameList { set; get; }
        private PamaterOperationType SolutionNamePOT;
        public void SetSolutionName(String info, PamaterOperationType pot) { this.SolutionName = info; this.SolutionNamePOT = pot; }
        private String GetSolutionNameSqlForSharp()
        {
            String sql = ""; switch (SolutionNamePOT)
            {
                case PamaterOperationType.StringContains: sql = "SolutionName like '%@SolutionName%'"; break;
                case PamaterOperationType.Equal: sql = "SolutionName=@SolutionName"; break;
                case PamaterOperationType.GreaterEqual: sql = "SolutionName>=@SolutionName"; break;
                case PamaterOperationType.GreaterThan: sql = "SolutionName>@SolutionName"; break;
                case PamaterOperationType.LessEqual: sql = "SolutionName<=@SolutionName"; break;
                case PamaterOperationType.LessThan: sql = "SolutionName<=@SolutionName"; break;
                case PamaterOperationType.In: sql = "SolutionName in(" + String.Join(",", this.SolutionNameList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "SolutionName in('" + String.Join("','", this.SolutionNameList) + "')"; break;
            }
            return sql;
        }
        public String ConfigContent { set; get; }
        public List<String> ConfigContentList { set; get; }
        private PamaterOperationType ConfigContentPOT;
        public void SetConfigContent(String info, PamaterOperationType pot) { this.ConfigContent = info; this.ConfigContentPOT = pot; }
        private String GetConfigContentSqlForSharp()
        {
            String sql = ""; switch (ConfigContentPOT)
            {
                case PamaterOperationType.StringContains: sql = "ConfigContent like '%@ConfigContent%'"; break;
                case PamaterOperationType.Equal: sql = "ConfigContent=@ConfigContent"; break;
                case PamaterOperationType.GreaterEqual: sql = "ConfigContent>=@ConfigContent"; break;
                case PamaterOperationType.GreaterThan: sql = "ConfigContent>@ConfigContent"; break;
                case PamaterOperationType.LessEqual: sql = "ConfigContent<=@ConfigContent"; break;
                case PamaterOperationType.LessThan: sql = "ConfigContent<=@ConfigContent"; break;
                case PamaterOperationType.In: sql = "ConfigContent in(" + String.Join(",", this.ConfigContentList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "ConfigContent in('" + String.Join("','", this.ConfigContentList) + "')"; break;
            }
            return sql;
        }
        public int? Version { set; get; }
        public List<int> VersionList { set; get; }
        public int? VersionMax { set; get; }
        public int? VersionMin { set; get; }
        public void SetVersion(int? max, int? min) { this.VersionMax = max; this.VersionMin = min; this.VersionPOT = PamaterOperationType.Between; }
        private PamaterOperationType VersionPOT;
        public void SetVersion(int? info, PamaterOperationType pot) { this.Version = info; this.VersionPOT = pot; }
        private String GetVersionSqlForSharp()
        {
            String sql = ""; switch (VersionPOT)
            {
                case PamaterOperationType.Between: sql = "Version between @VersionMin to @VersionMax"; break;
                case PamaterOperationType.StringContains: sql = "Version like '%@Version%'"; break;
                case PamaterOperationType.Equal: sql = "Version=@Version"; break;
                case PamaterOperationType.GreaterEqual: sql = "Version>=@Version"; break;
                case PamaterOperationType.GreaterThan: sql = "Version>@Version"; break;
                case PamaterOperationType.LessEqual: sql = "Version<=@Version"; break;
                case PamaterOperationType.LessThan: sql = "Version<=@Version"; break;
                case PamaterOperationType.In: sql = "Version in(" + String.Join(",", this.VersionList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "Version in('" + String.Join("','", this.VersionList) + "')"; break;
            }
            return sql;
        }
    }
}