/*Comparaison commerciaux*/
var a = 1996456789;
var b = 1996456789;
var c = 1996456789;
var d = 1996456789;
var e = 1996456789;
function comm1Treatment() {
    var com1 = document.getElementById("Comm1");
    a = com1.selectedIndex;
    return a;
}

function comm2Treatment() {
    var com2 = document.getElementById("Comm2");
    b = com2.selectedIndex;
    return b;
}

function comm3Treatment() {
    var com3 = document.getElementById("Comm3");
    c = com3.selectedIndex;
    return c;
}

function comm4Treatment() {
    var com4 = document.getElementById("Comm4");
    d = com4.selectedIndex;
    return d;
}

function comm5Treatment() {
    var com5 = document.getElementById("Comm5");
    e = com5.selectedIndex;
    return e;
}

function Sent() {
    var slam = document.getElementById("applyFilter");
    var link = "/Operations/ComparaisonCommerciaux?" + "id1=" + comm1Treatment() + "&id2=" + comm2Treatment() + "&id3=" + comm3Treatment() + "&id4=" + comm4Treatment() + "&id5=" + comm5Treatment();
    window.location = link;
}

/*Filtre par date des projet*/
var datDeb;
var datFin;

function getDateDeb() {
    datDeb = document.getElementById("dateDebut").value;
    return datDeb;
}

function getDateFin() {
    datFin = document.getElementById("dateFin").value;
    return datFin;
}

function Sent1() {
    var date1;
    var date2;
    var today = new Date();
    var topYear;
    var slam = document.getElementById("applyFilter");

    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0');
    var yyyy = today.getFullYear();

    today = yyyy + '-' + mm + '-' + dd;
    topYear = yyyy+ '-01-01'
    

    if (getDateDeb() === "") {
        date1 = topYear;
    } else {
        date1 = getDateDeb();
    }

    if (getDateFin() === "") {
        date2 = today;
    } else {
        date2 = getDateFin();
    }

    var link = "/Operations/FiltreProjetParDelais?" + "creation=" + date1 + "&finalisation=" + date2;
    window.location = link;
}