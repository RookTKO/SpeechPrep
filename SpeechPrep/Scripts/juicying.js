
//"use strict";
window.addEventListener("scroll", () => {
    const navBar = document.getElementsByTagName("nav")[0];
    if (this.scrollY != 0) {
        navBar.setAttribute("id", "navBarShadowIn");
    }
    else {
        navBar.setAttribute("id", "navBarShadowOut");
    }
})
window.onload = function () {
    console.log("working");
    Particles.init({
        selector: '.contextCanvasBG',

        responsive: [
            {
                breakpoint: 2560,
                options: {
                    maxParticles: 100,
                    sizeVariations: 5,
                    speed: 0.66,
                    color: ['#48F2E3', '#404B69', '#48F2E3'],
                    connectParticles: true
                }
            }, {
                breakpoint: 1440,
                options: {
                    maxParticles: 100,
                    sizeVariations: 3,
                    speed: 0.66,
                    color: ['#48F2E3', '#404B69', '#48F2E3'],
                    connectParticles: true
                }
            }, {
                breakpoint: 1024,
                options: {
                    maxParticles: 100,
                    sizeVariations: 3,
                    speed: 0.66,
                    color: ['#48F2E3', '#404B69', '#48F2E3'],
                    connectParticles: true
                }
            },{
                breakpoint:768,
                options: {
                    maxParticles: 100,
                    sizeVariations: 3,
                    speed: 0.66,
                    color: ['#48F2E3', '#404B69', '#48F2E3'],
                    connectParticles: true
                }
            }, {
                breakpoint: 767,
                options: {
                    maxParticles: 0
                }
            }
        ]
    });

};
