// coding implementation
function getValue(id){
    return document.getElementById(id).value;
}
function validate() {
    var from = getValue('from');
    var to = getValue('to');
    var isNumfrom = isNaN(from);
    var isNumto = isNaN(to);
    if(isNumfrom == true || isNumto == true) {
        alert("Gia phai la so!");
    }
    else {
        var x = parseInt(from);
        var y = parseInt(to);
        if(x>0 && y>0)
            return;
        else
            alert("Gia phai la so tu nhien!");
    }
}
// end coding implementation