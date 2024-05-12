function updateFontStyle(input) {
    input.style.fontFamily = "'Kriptoniano'";
}
document.querySelector('form').addEventListener('submit', function () {
    var textareaValue = document.getElementById('texto').value;
    document.getElementById('kripto').value = textareaValue;
});

 


