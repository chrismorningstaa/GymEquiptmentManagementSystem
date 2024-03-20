const sbarClick = document.querySelector(".toggle-btn");

sbarClick.addEventListener("click", function () {
    document.querySelector("#sidebar").classList.toggle("expand");
});
