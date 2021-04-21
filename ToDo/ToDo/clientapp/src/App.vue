<template>
  <div id="app">
    <h1> Ola Mundo com Aspnetcore e vue</h1>
    <hr>
    <div class="wrapper-temps">
      <Temperatura v-for="(t,i) in temps" :temperatura="t" :key="i"/>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
import Temperatura from '@/components/Temperatura'

export default {
  name: 'app',
  components: {
      Temperatura,
  },
  data() {
    return {
      temps: []
      
    }
  },
  methods:{
    getdata(){
       axios.get('/api/WeatherForecast')
       .then(resp => this.temps = resp.data);
    }
  },
  created () {
    setInterval(() => {
      this.getdata();  
    }, 5000);
    
  },
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.wrapper-temps{
    display: flex;
    justify-content: space-between;
}
</style>
