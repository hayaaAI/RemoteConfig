/*
Navicat MySQL Data Transfer

Source Server         : RemoteConfig_Dev
Source Server Version : 50505
Source Host           : 192.168.31.252:3306
Source Database       : RemoteConfig

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2018-09-25 21:43:34
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `AppConfig`
-- ----------------------------
DROP TABLE IF EXISTS `AppConfig`;
CREATE TABLE `AppConfig` (
  `AppConfigId` int(11) NOT NULL AUTO_INCREMENT,
  `AppId` int(11) NOT NULL,
  `SolutionID` varchar(1024) NOT NULL,
  `SolutionName` varchar(100) NOT NULL,
  `ConfigContent` longtext NOT NULL,
  `Version` int(11) NOT NULL DEFAULT 0,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  `UpdateTime` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`AppConfigId`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of AppConfig
-- ----------------------------
INSERT INTO `AppConfig` VALUES ('12', '4', '6c5e62a0-7d5e-4b3a-80a6-9b8ff8b0d5ad', '安全服务站点配置', '', '1', '2018-09-06 14:34:02', '2018-09-06 14:34:02');
INSERT INTO `AppConfig` VALUES ('13', '6', '4b897adb-54b9-4203-9d59-286b2570396a', '自动化编码管理_UISite', '{\"authUrl\": \"#security#api/UserAuth/CompanyUserLogin\",\"codeSolutionGetUrl\": \"#autocode#api/solutiontemplate/Get\",\"codeSolutionGetListUrl\": \"#autocode#api/solutiontemplate/GetPager\",\"codeSolutionAddUrl\": \"#autocode#api/solutiontemplate/Add\",\"codeSolutionEditUrl\": \"#autocode#api/solutiontemplate/Edit\",\"codeSolutionDeleteUrl\": \"#autocode#api/solutiontemplate/Delete\",\"codeGenUrl\": \"#autocode#api/solutiontemplate/GenCode\",\"codeGetFileUrl\": \"#autocode#\",\"codeTemplateGetUrl\": \"#autocode#api/solutiontemplate/GetCodeTemplate\",\"codeTemplateGetListUrl\": \"#autocode#api/solutiontemplate/GetCodeTemplateList\",\"codeTemplateAddUrl\": \"#autocode#api/solutiontemplate/AddCodeTemplate\",\"codeTemplateEditUrl\": \"#autocode#api/solutiontemplate/EditCodeTemplate\",\"codeTemplateDeleteUrl\": \"#autocode#api/solutiontemplate/DeleteCodeTemplate\",\"dataConnectionGetUrl\": \"#autocode#api/dataConnection/Get\",\"dataConnectionGetListUrl\": \"#autocode#api/dataConnection/GetPager\",\"dataConnectionAddUrl\": \"#autocode#api/dataConnection/Add\",\"dataConnectionEditUrl\": \"#autocode#api/dataConnection/Edit\",\"dataConnectionDeleteUrl\": \"#autocode#api/dataConnection/Delete\"}', '1', '2018-09-07 14:06:02', '2018-09-22 22:37:47');
INSERT INTO `AppConfig` VALUES ('14', '7', '49afd2de-ac06-4635-b8a5-2681bd23a19b', '企业智能核心站点', '{\"authUrl\": \"#security#api/UserAuth/CompanyUserLogin\",\"appConfigGetUrl\": \"#remoteconfig#api/appconfig/Get\",\"appConfigPagerUrl\": \"#remoteconfig#api/appconfig/GetPager\",\"appConfigAddUrl\": \"#remoteconfig#api/appconfig/Add\",\"appConfigEditUrl\": \"#remoteconfig#api/appconfig/Edit\",\"appConfigDeleteUrl\": \"#remoteconfig#api/appconfig/Delete\",\"componentConfigGetUrl\": \"#remoteconfig#api/componentconfig/Get\",\"componentConfigPagerUrl\": \"#remoteconfig#api/componentconfig/GetPager\",\"componentConfigAddUrl\": \"#remoteconfig#api/componentconfig/Add\",\"componentConfigEditUrl\": \"#remoteconfig#api/componentconfig/Edit\",\"componentConfigDeleteUrl\": \"#remoteconfig#api/componentconfig/Delete\",\"appPagerUrl\": \"#core#api/app/GetPager\",\"componentPagerUrl\": \"#core#api/component/GetPager\"}', '1', '2018-09-23 00:38:12', '2018-09-23 03:16:10');
INSERT INTO `AppConfig` VALUES ('15', '8', '25131564-78b5-4fb6-9b90-3e5f89652842', '企业智能核心Rpc', '{}', '1', '2018-09-23 02:29:18', '2018-09-23 02:29:46');
INSERT INTO `AppConfig` VALUES ('16', '9', '8baf31eb-b2df-4ec5-bf00-e4cf757edc92', '远程配置管理_UISite', '{\"authUrl\": \"#security#api/UserAuth/CompanyUserLogin\",\"appConfigGetUrl\": \"#remoteconfig#api/appconfig/Get\",\"appConfigPagerUrl\": \"#remoteconfig#api/appconfig/GetPager\",\"appConfigAddUrl\": \"#remoteconfig#api/appconfig/Add\",\"appConfigEditUrl\": \"#remoteconfig#api/appconfig/Edit\",\"appConfigDeleteUrl\": \"#remoteconfig#api/appconfig/Delete\",\"appComponentAddUrl\": \"#remoteconfig#api/appconfig/AddComponentConfig\",\"appComponentDeleteUrl\": \"#remoteconfig#api/appconfig/RemoveComponentConfig\",\"componentConfigGetUrl\": \"#remoteconfig#api/componentconfig/Get\",\"componentConfigPagerUrl\": \"#remoteconfig#api/componentconfig/GetPager\",\"componentConfigAddUrl\": \"#remoteconfig#api/componentconfig/Add\",\"componentConfigEditUrl\": \"#remoteconfig#api/componentconfig/Edit\",\"componentConfigDeleteUrl\": \"#remoteconfig#api/componentconfig/Delete\",\"appComponentListUrl\": \"#remoteconfig#api/componentconfig/GetList\",\"appPagerUrl\": \"#core#api/app/GetPager\",\"componentPagerUrl\": \"#core#api/component/GetPager\"}', '1', '2018-09-23 19:48:22', '2018-09-23 19:48:22');

-- ----------------------------
-- Table structure for `AppInstance`
-- ----------------------------
DROP TABLE IF EXISTS `AppInstance`;
CREATE TABLE `AppInstance` (
  `AppInstanceId` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(200) NOT NULL,
  `AppId` int(11) NOT NULL,
  `CreateTime` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp(),
  PRIMARY KEY (`AppInstanceId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of AppInstance
-- ----------------------------

-- ----------------------------
-- Table structure for `AppUser`
-- ----------------------------
DROP TABLE IF EXISTS `AppUser`;
CREATE TABLE `AppUser` (
  `AppUserId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '',
  `Title` varchar(50) DEFAULT NULL,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  `UpdateTime` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`AppUserId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of AppUser
-- ----------------------------

-- ----------------------------
-- Table structure for `ComponentConfig`
-- ----------------------------
DROP TABLE IF EXISTS `ComponentConfig`;
CREATE TABLE `ComponentConfig` (
  `ComponentConfigId` int(11) NOT NULL AUTO_INCREMENT,
  `ComponentId` int(11) NOT NULL,
  `Content` longtext NOT NULL,
  `Version` int(11) NOT NULL DEFAULT 1,
  `ComponentConfigTitle` varchar(100) NOT NULL,
  `IsDefault` bit(1) NOT NULL DEFAULT b'0',
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  `UpdateTime` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`ComponentConfigId`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ComponentConfig
-- ----------------------------
INSERT INTO `ComponentConfig` VALUES ('71', '10017', '{  \"cacheConfig\": {    \"redisConfigs\": [      {        \"name\": \"default\",        \"hostName\": \"192.168.31.65\",        \"port\": 10004,        \"serverPwd\": \"\"      }    ]  },  \"appSettings\": null,  \"connectionStrings\": {    \"settings\": [      {        \"name\": \"HayaaSecurity\",        \"connection\": \"Data Source=192.168.31.252;Initial Catalog=HayaaSecurity;Persist Security Info=True;User ID=securitydbu;password=securityDBuserpd18?2;SslMode=none\"      }    ]  }}', '1', '用户验证服务', '', '2018-09-06 14:34:02', '2018-09-20 17:10:28');
INSERT INTO `ComponentConfig` VALUES ('73', '10013', '{\"cacheConfig\": {\"redisConfigs\": [{\"name\": \"default\",\"hostName\": \"192.168.31.65\",\"port\": 10004,\"serverPwd\": \"\"}]},\"appSettings\": null,\"connectionStrings\": {\"settings\": [{\"name\": \"Core\",\"connection\": \"Data Source=192.168.31.252;Initial Catalog=Core;Persist Security Info=True;User ID=coredbu;password=coreDBuserpd18?3;SslMode=none\"}]}}', '1', '企业智能核心服务', '', '2018-09-23 00:49:10', '2018-09-23 00:49:10');
INSERT INTO `ComponentConfig` VALUES ('74', '10015', '{\"appSettings\": null,\"connectionStrings\": null,\"cacheConfig\": {\"redisConfigs\": [{\"name\": \"default\",\"hostName\": \"192.168.31.65\",\"port\": 10004,\"serverPwd\": \"\"}]},\"sessionLength\": 3000,\"onlyBaseAuth\": true}', '1', '企业web验证服务', '', '2018-09-23 00:55:42', '2018-09-23 03:36:33');
INSERT INTO `ComponentConfig` VALUES ('75', '10014', '{\n	\"appSettings\": null,\n	\"connectionStrings\": null,\n	\"serviceConfig\": {\n		\"sessionTimeout\": 0,\n		\"cpuCore\": 0,\n		\"serviceRegUrl\": null,\n		\"servicePubliceUrl\": null,\n		\"keepUrl\": null,\n		\"providerConfiguation\": {\n			\"name\": \"defaultService\",\n			\"group\": \"defaultGroup\",\n			\"port\": 10014,\n			\"messageSize\": 1048576,\n			\"packages\": null,\n			\"assemblyNames\": \"Hayaa.CompanyAICore.Service.dll,Hayaa.CompanyAICore.Service.Core.dll\"\n		},\n		\"consumerConfiguation\": null\n	}\n}', '1', '企业智能核心RPC服务端', '', '2018-09-23 02:26:20', '2018-09-23 02:26:20');

-- ----------------------------
-- Table structure for `Rel_AppConfig_ComponentConfig`
-- ----------------------------
DROP TABLE IF EXISTS `Rel_AppConfig_ComponentConfig`;
CREATE TABLE `Rel_AppConfig_ComponentConfig` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AppConfigId` int(11) NOT NULL,
  `AppConfigVersion` int(11) NOT NULL,
  `SolutionID` varchar(1024) NOT NULL,
  `ComponentConfigId` int(11) NOT NULL,
  `ComponentConfigVersion` int(11) NOT NULL,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of Rel_AppConfig_ComponentConfig
-- ----------------------------
INSERT INTO `Rel_AppConfig_ComponentConfig` VALUES ('70', '12', '1', '6c5e62a0-7d5e-4b3a-80a6-9b8ff8b0d5ad', '71', '1', '2018-09-06 14:34:02');
INSERT INTO `Rel_AppConfig_ComponentConfig` VALUES ('74', '15', '1', '25131564-78b5-4fb6-9b90-3e5f89652842', '75', '1', '2018-09-23 02:27:15');
INSERT INTO `Rel_AppConfig_ComponentConfig` VALUES ('75', '15', '1', '25131564-78b5-4fb6-9b90-3e5f89652842', '73', '1', '2018-09-23 02:32:10');
INSERT INTO `Rel_AppConfig_ComponentConfig` VALUES ('79', '14', '1', '49afd2de-ac06-4635-b8a5-2681bd23a19b', '73', '1', '2018-09-23 20:14:11');
INSERT INTO `Rel_AppConfig_ComponentConfig` VALUES ('80', '14', '1', '49afd2de-ac06-4635-b8a5-2681bd23a19b', '74', '1', '2018-09-23 20:14:19');
