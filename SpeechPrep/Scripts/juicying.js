
"use strict";
window.addEventListener("scroll", () => {
    const navBar = document.getElementsByTagName("nav")[0];
    if (this.scrollY != 0) {
        navBar.setAttribute("id", "navBarShadowIn");
    }
    else {
        navBar.setAttribute("id", "navBarShadowOut");
    }
})
console.log("test");


