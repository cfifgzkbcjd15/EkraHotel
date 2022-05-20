import Login from './components/autorization/loginUser.vue'
import {createRouter,createWebHistory} from 'vue-router'
import Salary from './components/AdminPanel/Salary.vue'
import Room from './components/AdminPanel/Rooms.vue'
import LoginStaff from './components/autorization/LoginStaff.vue'

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
  
  