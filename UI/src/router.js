import Login from './components/autorization/loginUser.vue'
import {createRouter,createWebHistory} from 'vue-router'
import Salary from './components/AdminPanel/Salary.vue'
import Room from './components/AdminPanel/Rooms.vue'
import LoginStaff from './components/autorization/LoginStaff.vue'
import error from './components/errors/403.vue'
import errors from './components/errors/500.vue'
import notfound from './components/errors/notfound.vue'

const routes=[
    {
        path: '/loginUser',
        component: Login,
        meta:{
            title:"Авторизация",
            layout:"empty"
        }
    },
    {
        path: '/',
        redirect: '/loginUser'
    },
    {
        path: '/loginStaff',
        component: LoginStaff,
        meta:{
            title:"Авторизация",
            layout: "empty"
        }
    },
    {
        path: '/AdminPanel/',
        component: Room,
        meta:{
            title:"Админка"
        }
    },
    {
        path: '/AdminPanel/Salary',
        component: Salary,
        meta:{
            title:"Зарплата"
        }
    },
    {
      path: '/error/403',
      component: error,
      // meta:{
      //   layout: "Auth"
    },
    {
      path: '/error/500',
      component: errors,
      // meta:{
      //   layout: "Auth"
    },
    {
      path: '/:pathMatch(.*)*',
      component: notfound,
      // meta:{
      //   layout: "Auth"
    }

] 

const router = createRouter({
    history: createWebHistory(),
    routes
  })
  router.beforeEach((to, from, next) => {
    document.title = to.meta.title
     if (localStorage.token==null&&to.path != '/loginUser'&&to.path!='/LoginStaff') {
         next("/loginUser");
     }
     else if(localStorage.token!=null&&to.path == '/loginUser') {router.push("/")}
     else if(localStorage.token!=null&&to.path == '/LoginStaff') {router.push("/AdminPanel/")}
     else{
       next()
     }
  })
  export default router;
  
  