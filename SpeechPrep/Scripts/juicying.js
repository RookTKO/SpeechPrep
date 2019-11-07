"use strict";
window.addEventListener("scroll", () => {
    if (window.scrollY != 0) {
        console.log("NavBar moved");
        console.log(this.scrollY);
    }
})
console.log("test");