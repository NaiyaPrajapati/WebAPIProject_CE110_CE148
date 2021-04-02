// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#Textbox1").keyup(function () {
        var input, filter, ul, li, a, i, txtValue;
        var array = [];
        var myArr = [];
        input = $("#Textbox1");
        filter = input.val().toUpperCase()
        li = $(".col-md-3");
        //  console.log(input);
        console.log(filter);
        //console.log(li);
        a = $(".email");
        for (i = 0; i < li.length; i++) {

            txtValue = a[i].innerText;
            array.push(txtValue);
            console.log(txtValue);
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                li[i].style.display = "";
                //li[i].classlist.remove("mystyle");
            } else {
                li[i].style.display = "none";

                //li[i].classlist.add("mystyle");
            }
        }
        //console.log(array);
        //myArr.filter(array => array.includes(filter));
        //console.log(myArr);
    });
});