<template>
    <div style="margin-left: 25px">

        <el-table :data="tableData">
            <el-table-column
                    label="ID"
                    width="80">
                <template slot-scope="scope">
                    <span>{{ scope.row.componentId }}</span>
                </template>
            </el-table-column>
            <el-table-column
                    label="名称"
                    width="180">
                <template slot-scope="scope">
                    <span>{{ scope.row.title }}</span>
                </template>
            </el-table-column>
            <el-table-column
                    label="创建时间"
                    width="160">
                <template slot-scope="scope">
                    <span>{{ scope.row.createTime }}</span>
                </template>
            </el-table-column>
            <el-table-column
                    label="更新时间"
                    width="160">
                <template slot-scope="scope">
                    <span>{{ scope.row.updateTime }}</span>
                </template>
            </el-table-column>
            <el-table-column label="操作">
                <template slot-scope="scope" >
                    <el-button size="mini" @click="editConfig(scope.row.componentId)">编辑配置</el-button>
                  </template>
            </el-table-column>
        </el-table>
        <div style="float: right" v-show="pagerData.totalPage>0">
            <el-pagination
                    @current-change="getPager"
                    layout="prev, pager, next"
                    :total="pagerData.totalPage">
            </el-pagination>
        </div>
    </div>
</template>

<script>
  import httphelper from '@/util/httphelper'
  import webstore from '@/webstore'

    export default {
        name: "ComponentList",
        created: function () {
            this.getPager(1);
        },
        data: function () {
            return {
                pagerData: {
                    totalPage: 0
                },
                tableData: []
            }
        },
        methods: {
            getPager: function(page) {
                var that = this;
                httphelper.authedpostform(webstore.urls.componentPagerUrl, {"page": page, "size": 10},
                    function (data) {
                        that.tableData = data.data;
                        that.pagerData.totalPage = data.total / data.pageSize;
                        if (that.pagerData.totalPage < 1) {
                            that.pagerData.totalPage = 1;
                        }
                    })
            },
            editConfig: function(id) {
                this.$router.push("/home/componentconfiglist/" + id);
            }
        }
    }
</script>

<style scoped>

</style>
