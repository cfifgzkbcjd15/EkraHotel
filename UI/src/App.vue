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
body {
  background: #211F20;
  color: #ffffff;
}

.form-floating {
  color: #171717;
}

.btn-primary {
  background: #00A96B;
  border-color: #00A96B;
}

.navbar {
  box-shadow: 4px 0px 4px rgba(0, 0, 0, 0.25);
  border-radius: 0px 0px 15px 15px;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  margin-top: 10%;
}
</style>
