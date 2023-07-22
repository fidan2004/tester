//class Slider{
//    constructor(){
//        this.count = 0
//    }
//    render(data){
//        for (let index = 0; index < data.length; index++) {
//            data[index].style.transform = `translateX(-${this.count *  254}px)`
//        }
//    }

//    buttons(leftBtn, rightBtn, data){
//        rightBtn.addEventListener('click', ()=>{
//            if((data.length - 6) > this.count){
//                this.count ++ 
//            }else{
//                this.count = 0
//            }
//            if((data.length-6 ) > this.count){
//                this.count ++ 
//            this.render(data)
//            }
//        })
//        leftBtn.addEventListener('click', ()=>{
//            if(this.count >= 0){
//                this.count --
//                this.render(data)
//            }
//        })
//    }
//}

//let slider = new Slider()

//const slider_container = document.querySelector('.slider_container')
//const leftBtn = document.querySelector('#leftBtn')
////const rightBtn = document.querySelector('#rightBtn')

//const getSliderImg = async () => {
//    return await fetch('./js/db.json')
//    .then(resp=> resp.json())
//    .then(data=>{
        
//        data.forEach(item => {
//            slider_container.innerHTML += `
//             <div class="slider_card">
//                <img src="${item.image}" alt="">
//            </div>
//            `
//        });
//        slider.buttons(leftBtn,rightBtn,slider_container.children)
//    })
//}


//getSliderImg()



//const array = [
//    {
//        title: 'New Arrival Collection',
//        desc: 'SUMMER 2023',
//        image :'./assest/images/slider-01_3000x.webp'
//    },
//    {
//        title: 'Save up to 70%',
//        desc: 'SUMMER SALE',
//        image :'./assest/images/slide2_2500x.webp'
//    },
//    {
//        title: 'Lookbook Collection',
//        desc: 'NEW SEASON',
//        image :'./assest/images/slide3_2500x.webp'
//    }
//]

//const sliders_card = document.querySelector('.sliders_card');
//const dots = document.querySelector('#dots');
//let timer = 5000
//let inc = 0



//let changeInc=(i)=>{
//    sliders(i)
//    timer = 5000
//    inc=i
//}

//function sliders(inc){
//    console.log(inc);
//    sliders_card.innerHTML = `
//             <div class="slider_img" >
//                <img id="slider_header_img" src="${array[inc].image}" alt="" />
//              </div>
//              <div class="container">
//                <div class="slider_text">
//                  <p id="slider_desc">${array[inc].desc}</p>
//                  <h3 id="slider_title"  class="animation">${array[inc].title}</h3>
//                  <button class="btn_square explore animationbtn">Explore Now</button>
//                </div>
//              </div>

//    `

//    dots.innerHTML = ''
//    for(let i = 0; i < array.length; i++){
//    dots.innerHTML += `<span onclick="changeInc(${i})" class="dot ${inc==i ? 'active_dot':null}"></span>`
//    }
    
//}
//sliders(0)
 
// setInterval(()=>{
//    if(inc == 2){
//        inc=0;
//    }else{
//        inc++
//    }
//    sliders(inc)

// },timer)


const emailInput = document.getElementById('emailInput')


function sendEmail() {
    emailjs.send('service_5p4gquf', 'template_nbneyio', { email: emailInput.value})
        .then(function (response) {
            console.log('SUCCESS!', response.status, response.text);
        }, function (error) {
            console.log('FAILED...', error);
        });
}

