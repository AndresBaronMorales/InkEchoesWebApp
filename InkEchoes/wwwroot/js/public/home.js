import Swiper from 'https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.mjs';

document.addEventListener("DOMContentLoaded", () => {
    var swiperBooks = new Swiper('.swiper-top-books', {
        effect: 'coverflow',
        grabCursor: true,
        centeredSlides: true,
        loop: true,
        slidesPerView: 'auto',
        coverflowEffect: {
            rotate: 0,
            stretch: 0,
            depth: 100,
            modifier: 2.5,
        },
        pagination: {
            el: '.swiper-pagination-books',
            clickable: true,
        },
        navigation: {
            nextEl: '.swiper-next-books',
            prevEl: '.swiper-prev-books',
        }
    });
})
