<template>
    <div style="margin-left: 25px">
        <div style="float: right">
            <el-button type="primary" @click="add">添加</el-button>
        </div>
        <el-table :data="tableData">
            <el-table-column
                    label="ID"
                    width="80">
                <template slot-scope="scope">
                    <span>{{ scope.row.appId }}</span>
                </template>
            </el-table-column>
            <el-table-column
                    label="名称"
                    width="120">
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
                <template slot-scope="scope">
                    <el-button size="mini" @click="edit(scope.row.appId)">编辑</el-button>
                    <el-button size="mini" @click="editConfig(scope.row.appId)">配置管理</el-button>
                    <el-button size="mini" type="danger" @click="del(scope.row.appId)">删除</el-button>
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
    import httphelper from '../../util/httphelper'
    import urls from '../../urlstatic'

    export default {
        name: "AppList",
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
                httphelper.authedpostform(urls.appPagerUrl, {"page": page, "size": 10},
                    function (data) {
                        that.tableData = data.data;
                        that.pagerData.totalPage = data.total / data.pageSize;
                        if (that.pagerData.totalPage < 1) {
                            that.pagerData.totalPage = 1;
                        }
                    })
            },
            add: function() {
                this.$router.push("/home/appedit");
            },
            edit: function(id) {
                this.$router.push("/home/appedit/" + id);
            },
            editConfig: function(id) {
                this.$router.push("/home/appconfiglist/" + id);
            },
            del: function(id) {
                var that = this;
                httphelper.authedpostform(urls.appDeleteUrl, {"appId": id},
                    function (data) {
                        if(data)
                        that.$notify.success("操作成功");
                    });
            }
        }
    }
</script>

<style scoped>

</style>