import Login from './components/autorization/loginUser.vue'
import {createRouter,createWebHistory} from 'vue-router'

const routes=[
    {
        path: '/loginUser',
        component: Login,
        // meta:{
        //   layout: "Auth"
    },
    // {
    //     path: '/',
    //     redirect: '/loginUser'
    // }
] 

const router = createRouter({
    history: createWebHistory(),
    routes
  })
  router.beforeEach((to, from, next) => {
    document.title = to.meta.title
     if (localStorage.token==null&&to.path != '/loginUser') {
         next("/loginUser");
     }
     else if(localStorage.token!=null&&to.path == '/loginUser') {router.push("/")}
     else{
       next()
     }
  })
  export default router;
  
  