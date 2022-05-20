import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import Default from './components/layouts/Default.vue'

createApp(App).component("default-layout",Default)
.use(router)
.mount('#app')
