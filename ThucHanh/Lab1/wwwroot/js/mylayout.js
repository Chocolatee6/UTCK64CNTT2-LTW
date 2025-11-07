document.addEventListener('DOMContentLoaded', function () {
    console.log('MyLayout script loaded successfully.');

    // Thêm chức năng cơ bản cho Header (ví dụ: đổi màu khi cuộn)
    var header = document.querySelector('.main-header');

    window.addEventListener('scroll', function () {
        if (window.scrollY > 50) {
            header.style.backgroundColor = '#2c3e50'; // Màu tối hơn khi cuộn
        } else {
            header.style.backgroundColor = '#34495e'; // Màu ban đầu
        }
    });

    // Ví dụ: Thêm sự kiện click cho sidebar
    var sidebarItems = document.querySelectorAll('.sidebar li');
    sidebarItems.forEach(function (item) {
        item.addEventListener('click', function () {
            alert('Clicked on: ' + this.textContent);
        });
    });
});