<template>
  <div>
    <router-view></router-view>
  </div>
</template>

<script>
  import httphelper from '@/util/httphelper'
  import webstore from '@/webstore'

  export default {
    name: "AppFrame",
    data: function () {
      return {}
    },
    created: function () {
      this.loader()
    },
    methods: {
      loader: function () {
        //console.log("loader")
        var that = this;
        httphelper.postform(webstore.configUrl, {
          "sid": "8baf31eb-b2df-4ec5-bf00-e4cf757edc92",
          "v": 1
        }, function (configData) {
          webstore.urls = JSON.parse(configData);
          //console.log(webstore.urls);
          for (var p in webstore.urls) {
            for (var a in webstore.baseUrl) {
              webstore.urls[p] = webstore.urls[p].replace("#"+a+"#", webstore.baseUrl[a]);
            }
          }
          that.$router.push("/home");
        });

      }
    }
  }
</script>

<style scoped>

</style>
