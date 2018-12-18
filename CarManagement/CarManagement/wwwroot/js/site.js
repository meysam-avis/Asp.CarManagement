// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


$(document).ready(function () {
    $(".toggle-modal").click(function () {

        // alert($(this));

        $(this).next(".modal").toggleClass("is-active");


    });

    $(".close-modal").click(function () {

        // alert($(this));

        $(this).closest("div.modal").removeClass("is-active");


    });

    $("#myInput").keyup(function () {


            var input, filter, table, tr, td, i, j, tds, c;


            input = document.getElementById("myInput");
            filter = input.value.toUpperCase();
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");
            for (i = 1; i < tr.length; i++) {

                tds = tr[i].getElementsByTagName("td");
                c = 0;
                for (j = 1; j < tds.length; j++) {
                    td = tr[i].getElementsByTagName("td")[j];

                    if (td) {
                        //  console.log("tr:"+i+" td:"+j);
                        if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                            // tr[i].style.display = "";
                            c++;
                            //  console.log("tr::" + i + " td::" + j);
                        }// else {
                        //  tr[i].style.display = "none";

                        // }
                    }




                }
                if (c === 0) tr[i].style.display = "none";
                else tr[i].style.display = "";


            }


        }


    );

    // $(".pdp").pDatepicker();
    $('.pdp').persianDatepicker({

        format: 'YYYY/MM/DD'

    });



});

