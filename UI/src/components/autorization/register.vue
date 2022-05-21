<template>
 <div class="container">
        <div class="row">
            <div class="col-sm-4">

            </div>
            <div class="col-sm-4">
                <h1 class="h3 mb-3 fw-normal">Регистрация</h1>

                <div class="mt-2 form-floating">
                    <input type="email" class="form-control" v-model="FullName" placeholder="ФИО">
                    <label >Введите ФИО</label>
                </div>

                <div class="mt-2 form-floating">
                    <input type="email" class="form-control" v-model="Email" placeholder="name@example.com">
                    <label >Введите почту</label>
                </div>
                <div class="mt-2 form-floating">
                    <input type="password" class="form-control" v-model="Password"  placeholder="Password">
                    <label >Введите пароль</label>
                </div>

                <div class="mt-2 form-floating">
                    <input type="password" class="form-control" v-model="ConfirmPassword"  placeholder="ConfirmPassword">
                    <label >Повторите пароль</label>
                </div>
                
                <div class="row">
                    <div class="col-sm-6">
                        <button class="mt-2 w-100 btn btn-lg btn-primary" @click="register()"><h6>Зарегистрироваться</h6></button>
                    </div>
                    <div class="col-sm-6"></div>
                </div>
            </div>

            <div class="col-sm-4">

            </div>
        </div>
    </div>
</template>
    <script>
import api from "../../api"
export default{
    data(){
        return{
        FullName:"",
        Email:"",
        Password:"",
        ConfirmPassword:"",
        }
    },
    methods:{
        register(){
            if (this.Password == this.ConfirmPassword )
            {
            api.post('Customers',{FullName:this.FullName, Email:this.Email, Password:this.Password})
            .then(
            this.$router.push("/loginUser")
            )}
        }
    }
}
</script>