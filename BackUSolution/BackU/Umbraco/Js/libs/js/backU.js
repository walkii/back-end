$(document).ready(function () {
    console.log('hello');
    $('.shForm').hide();

    $("#editButton").click(function () {
        var title = document.getElementById("titleObjectiveItem").innerHTML;
       
        document.getElementById("829c467b-559a-4274-c9c4-cedaccb87577").value = title;
        document.getElementById("descriptionfield").childNodes[1].id = "description";
        var description = document.getElementById("description").innerHTML;
        document.getElementById("16608a48-d19b-44f3-9097-16604362d913").value = description;
        $('.shForm').show();
        $('.shContent').hide();
        var idPage = document.getElementById("IdPage").innerHTML;
        document.getElementById("9865fc7d-75a6-457c-801f-d34a60e779f5").value = idPage;
        $('#20bc5bcd-aea3-401f-a259-88f60ada801f').hide();
    });
});