<template>
                <div class="container">
                <div class="row">
                    <div class="col-sm-3">

                    </div>
                    <div class="col-sm-6">
                        <h1 class="h3 mb-3 fw-normal">Вход</h1>

                        <div class="form-floating">
                            <input type="email" class="form-control" v-model="Email" placeholder="name@example.com">
                            <label for="floatingInput">Введите почту</label>
                        </div>
                        <div class="form-floating">
                            <input type="password" class="form-control" v-model="Password"  placeholder="Password">
                            <label for="floatingPassword">Введите пароль</label>
                        </div>

                        <div class="checkbox mb-3">
                            <label>
                                <input type="checkbox" value="remember-me"> Запомнить
                            </label>
                        </div>

                        <div class="row">
                            <div class="col-sm-6">
                                <button @click="auth()">Войти</button>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-3">

                    </div>
                </div>
            </div>
</template>
<script>
import api from "../../api"
export default {
    data() {
        return{
            Email:"",
            Password:""
        }
    },
    methods:{
        auth(){
            api.post('Auth/Admin',this.$data)
            .then((res)=>{if(res.data!=null)
            {
            localStorage.token=res.data.token;
            localStorage.fullName=res.data.fullName
            //this.$router.push("/")
            }})
        }
    }
}
</script>