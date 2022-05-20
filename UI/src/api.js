import axios from "axios"; 
const api=axios.create({
    baseURL: 'http://localhost:5217/api/'
});
api.interceptors.request.use(config=>{

    if(localStorage.getItem('token')){
        config.headers=
            {'Authorization': 'Bearer '+ localStorage.token}
    }
    return config
})
api.interceptors.response.use(function(config){
    if(localStorage.getItem('token')){
        config.headers=
            {'Authorization': 'Bearer '+ localStorage.token}
    }
    return config
},function(error){
    switch(String(error.response.status)){
        case '403':
            window.location="Error/403";
            break
        case '401':
            localStorage.clear()
            location.reload()
            break
        case '500':
            window.location="Error/500";
            break
    }
        
})
export default api