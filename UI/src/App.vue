<template>
  <component :is="layout">
    <router-view></router-view>
  </component>
</template>
<script>
export default {
   computed: {
            //Это самое вычисляемое свойство
            layout(){
                //Вернем имя шаблона из роута или дефолтное значение 
                  //(шаблон для страниц, для которых мы не указали шаблон)
                return this.$route.meta.layout || "default-layout" 
            }
        }
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
