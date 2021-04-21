<template>
    <div>
        <div class="temperatura-box">
            <h2 class="temp-heading">{{ temperatura.summary }}</h2>
            <hr>
            <label>Data:</label>
             <span>{{ temperatura.date | dtPtBr }}</span>
             <p> Temperaturas: 
                 {{ temperatura.temperatureC }}ºC | 
                 {{ temperatura.temperatureF }}ºF
            </p>
        </div>
    </div>
</template>

<script>
    export default {
        props:{
            temperatura:{
                type:Object,
                require: true
            },
            
        },
        filters: {
            dtPtBr: function(value) {
                return new Date(value).toLocaleDateString('pt-BR');
            }
        }
    }
</script>
<style scoped>

.temperatura-box{
    width: 250px;
    height: 150px;
    border: 1px solid #ccc;
    margin: 5px;
}

</style>
