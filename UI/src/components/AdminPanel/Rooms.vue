<template>
    
</template>
<script>
import api from "../../api"
export default{
    data(){
        return{
            model:[]
        }
    },
    methods:{
        refreshData(){
            api.get().then((res)=>{this.model=res.data})
        }
    },
    mounted:function(){
        this.refreshData()
    }
}
</script>
