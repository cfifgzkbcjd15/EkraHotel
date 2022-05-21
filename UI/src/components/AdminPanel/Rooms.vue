<template>
    <div class="conteiner">
        <div class="row">
            <div class="col-sm-2">
                
            </div>
            <div class="col-sm-8">
                <div class="btn-group">
                    <a @click="page1()" class="btn btn-primary">Комнаты</a>
                    <a @click="page2()" class="btn btn-primary">Отзывы</a>
                    <a @click="page3()" class="btn btn-primary">Выручка</a>
                </div>
                <main id="Romm">     
                <span>Отчет по комнатам</span>
                <table class="table table-sm table-dark">
                    <thead>
                        <tr>
                        <th scope="col">#</th>
                        <th scope="col">ФИО</th>
                        <th scope="col">Почта</th>
                        <th scope="col">Номер комнаты</th>
                        <th scope="col">Cвободна/Занята</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="item in model" :key="item.id">
                            <th scope="row">{{item.id}}</th>
                            <td>{{item.customers.fullName}}</td>
                            <td>{{item.customers.email}}</td>
                            <td>{{item.rooms.number}}</td>
                            <td v-if="item.customers.lives">Занята</td>
                            <td v-else>Свободна</td>
                        </tr>
                    </tbody>
                </table>
                </main>

                <main id="reviews" style="display:none">  
                <span>Отчет по отзывам</span>
                <table class="table table-sm table-dark">
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">ФИО</th>
                            <th scope="col">Почта</th>
                            <th scope="col">Дата</th>
                            <th scope="col">Отзыв</th>
                            <th scope="col">Оценка</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="col in reviews" :key="col.id">
                            <th scope="row">{{col.id}}</th>
                            <td>{{col.customers.fullName}}</td>
                            <td>{{col.customers.email}}</td>
                            <td>{{col.date}}</td>
                            <td>{{col.text}}</td>
                            <td>{{col.stars}}</td>
                        </tr>
                    </tbody>
                </table>
                </main>

                <main id="mony" style="display:none">  
                <span>Скоро да да скоро</span>
                </main>
            </div>
            <div class="col-sm-2">
            </div>
        </div>
    </div>
    
    
    
</template>
<script>
import api from "../../api"
export default{
    data(){
        return{
            model:[],
            reviews:[],
            mony:[],
        }
    },
    methods:{ 
        page1(){
            document.getElementById('Romm').style.display = 'block'
            document.getElementById('reviews').style.display = 'none'
            document.getElementById('mony').style.display = 'none'
        },
        page2(){
            document.getElementById('Romm').style.display = 'none'
            document.getElementById('reviews').style.display = 'block'
            document.getElementById('mony').style.display = 'none'
        },
        page3(){
            document.getElementById('Romm').style.display = 'none'
            document.getElementById('reviews').style.display = 'none'
            document.getElementById('mony').style.display = 'block'
        },
        refreshData(){
            api.get("Booking").then((res)=>{this.model=res.data})
            api.get("Reviews/Hostel").then((res)=>{this.reviews=res.data})
        }
    },
    mounted:function(){
        this.refreshData()
    }
}
</script>
