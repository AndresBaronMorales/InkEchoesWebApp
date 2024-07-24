document.addEventListener("DOMContentLoaded",()=> {
    const btnNav = document.getElementById("nav-item-btn");

    btnNav.addEventListener("click", () => {
        const menuNav = document.getElementById("nav-links");
        menuNav.classList.toggle("show-links");
        btnNav.classList.toggle("show-nav");
    });

})
