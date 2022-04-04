
// MENÜ KODLARI AŞAĞIDADIR
$(document).ready(function(){
    //menu id'li tag'in içindeki ul tag'ına sahip li'leri bul
    $('#menu').find('li:has(ul)').hover(
        function(){
            //Üzerine gelinen ul'lerden ilkini görünür yap
            $(this).find('ul:eq(0)').css('visibility','visible');
        }
        ,function(){
            //Üzerinde gelmediğim ul'leri görünmez yap
            $(this).find('ul').css('visibility','hidden');
        }
    );
});


// SLİDER KODLARI AŞAĞIDADIR

let slideIndex =0;
let allSlides =$(".slide");
let allDots=$(".dot").toArray();
$(".nextSlide").click(function(){
    if(allSlides.length==slideIndex +1){
        slideIndex=-1;
    }
    
    showSlide(++slideIndex);
})
$(".prevSlide").click(function(){
    
    if(slideIndex==0){
        slideIndex=allSlides.length;
    }
    showSlide(--slideIndex);

})

function showSlide(n){
    allSlides=$(".slide");
    for(let i=0; i<allSlides.length; i++){
        allSlides[i].style.display="none";
        allDots[i].classList.remove("active");
    }
    allSlides[n].style.display="block";
    allDots[n].classList.add("active");

    }

    
    $(".dot").click(function(){
        slideIndex=$(this).index();
        showSlide(slideIndex);

    })


    showSlide(slideIndex);

    // POP-UP İÇİN
    // Popup Al
    $("#popup-btn").click(function() {
        $(".popup-container").css({
            display:"block"
        })
    });
