import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import Default from './layouts/Default.vue'

createApp(App)
.use(router).component("default-layout",Default)
.mount('#app')
