<template>
  <div style="margin-left: 25px">
    <div style="float: right" v-show="isShowTable">
      <el-button type="primary" @click="switchAdd">添加</el-button>
      <el-button type="primary" @click="back">返回</el-button>
    </div>
    <div v-show="!isShowTable">
      <el-form label-width="120px" class="demo-ruleForm">
        <el-form-item label="组件配置Id">
          <el-input v-model="componentConfigId" style="width: 100px"></el-input>
          <el-button type="primary" @click="add">确定</el-button>
        </el-form-item>
      </el-form>
    </div>
    <el-table :data="tableData" v-show="isShowTable">
      <el-table-column
        label="ID"
        width="80">
        <template slot-scope="scope">
          <span>{{ scope.row.componentConfigId }}</span>
        </template>
      </el-table-column>
      <el-table-column
        label="名称"
        width="240">
        <template slot-scope="scope">
          <el-popover trigger="hover" placement="top">
            <p>组件ID: {{ scope.row.componentId }}</p>
            <p>配置版本: {{ scope.row.version }}</p>
            <div style="width: 300px;overflow: auto">配置: {{ scope.row.content }}</div>
            <p>是否组件默认配置: <span v-if="scope.row.isDefault">是</span><span v-else>否</span></p>
            <div slot="reference" class="name-wrapper">
              <el-tag size="medium">{{ scope.row.componentConfigTitle }}</el-tag>
            </div>
          </el-popover>
        </template>
      </el-table-column>
      <el-table-column label="操作">
        <template slot-scope="scope">
          <el-button size="mini" type="danger" @click="del(scope.row.componentConfigId)">删除</el-button>
        </template>
      </el-table-column>
    </el-table>
  </div>
</template>

<script>
  import httphelper from '@/util/httphelper'
  import webstore from '@/webstore'

  export default {
    name: "AppComponentList",
    created: function () {
      this.appConfigId = this.$route.params.aid;
      this.version = this.$route.params.v;
      this.getPager(1);
    },
    data: function () {
      return {
        isShowTable: true,
        appConfigId: 0,
        version: 0,
        componentConfigId: 0,
        tableData: []
      }
    },
    methods: {
      back:function(){
        this.$router.push("/home/applist");
      },
      getPager: function (page) {
        var that = this;
        httphelper.authedpostform(webstore.urls.appComponentListUrl, {
            "appConfigId": that.appConfigId,
            "version": that.version
          },
          function (data) {
            that.tableData = data;
          })
      },
      switchAdd: function () {
        this.isShowTable = false;
      },
      add: function () {
        var that = this;
        httphelper.authedpostform(webstore.urls.appComponentAddUrl, {
            "appConfigId": that.appConfigId,
            "componentConfigId": that.componentConfigId
          },
          function (data) {
            if (data) {
              that.$notify.success("操作成功");
              that.isShowTable = true;
              that.getPager(1);
            }
          });
      },
      del: function (componentConfigId) {
        var that = this;
        httphelper.authedpostform(webstore.urls.appComponentDeleteUrl, {
            "appConfigId": that.appConfigId,
            "componentConfigId": componentConfigId
          },
          function (data) {
            if (data) {
              that.$notify.success("操作成功");
              that.getPager(1);
            }
          });
      }
    }
  }
</script>

<style scoped>

</style>
