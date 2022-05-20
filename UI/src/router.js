import Login from './components/autorization/loginUser.vue'
import {createRouter,createWebHistory} from 'vue-router'

const routes=[
    {
        path: '/loginUser',
        component: Login,
    },
    {
        path: '/',
        redirect: '/loginUser'
    },
    {
        path: '/loginStaff',
        component: LoginStaff,
    },

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
  
  