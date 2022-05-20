<template>
{{model}}
{{incentives}}
    
</template>
<script>
import api from "../../api"
export default{
    data(){
        return{
            model:[],
            incentives:[]
        }
    },
    methods:{
        refreshData(){
            api.get("Salary").then((res)=>{this.model=res.data})
            api.get("Incentives").then((res)=>{this.incentives=res.data})
        }
    },
    mounted:function(){
        this.refreshData()
    }
}
</script>
