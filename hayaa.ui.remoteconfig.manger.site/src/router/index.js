import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/Login.vue'
import Main from '@/components/Main.vue'
import Index from '@/pages/Index.vue'
import Message from '@/pages/Message.vue'
import AppList from '@/pages/AppConfig/AppList.vue'
import AppConfigEdit from '@/pages/AppConfig/AppConfigEdit.vue'
import AppConfigList from '@/pages/AppConfig/AppConfigList.vue'
import AppComponentList from '@/pages/AppConfig/AppComponentList.vue'
import ComponentList from '@/pages/ComponentConfig/ComponentList.vue'
import ComponentConfigList from '@/pages/ComponentConfig/ComponentConfigList.vue'
import ComponentConfigEdit from '@/pages/ComponentConfig/ComponentConfigEdit.vue'


Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {path: '/login', component: Login},
    {
      path: '/home',
      component: Main,
      children: [
        {path: "index", component: Index},
        {path: "message", component: Message},
        {path: "applist", component: AppList},
        {path: "appconfiglist/:id", component: AppConfigList},
        {path: "appconfigedit/:aid/:id?", component: AppConfigEdit},
        {path: "appcomponentlist/:aid/:v", component: AppComponentList},
        {path: "componentlist", component: ComponentList},
        {path: "componentconfiglist/:id", component: ComponentConfigList},
        {path: "componentconfigedit/:cid/:id?", component: ComponentConfigEdit}
      ]
    }
  ]
})
