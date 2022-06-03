$(() => {
    $(".menu ul li a").click(function (event) {
        $(".menu ul li a").removeClass("active")
        $(this).addClass("active")
    })
    let sliderIndex = 0;
    let allSlides = $(".slide").toArray();

    $("#prevSlide").click(function(){
        if(sliderIndex==0){
            sliderIndex=allSlides.length
        }
        showSlide(--sliderIndex)
    })
    $("#nextSlide").click(function(){
        if(sliderIndex==allSlides.length-1){
            sliderIndex=-1
        }
        showSlide(++sliderIndex)
    })
    function showSlide(q) {
        for (var i = 0; i < allSlides.length; i++) {
            // allSlides[i].style.display = "none";
            $(".slide").eq(i).hide()
        }
        $(".slide").eq(q).fadeTo(1000, 1)
    }

    showSlide(sliderIndex);
})