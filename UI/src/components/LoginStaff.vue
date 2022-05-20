<template>
    
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