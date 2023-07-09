// coding implementation
function getValue(id){
    return document.getElementById(id).value.trim();
}
function validate() {
    var from = getValue('from');
    var to = getValue('to');
    var isNumfrom = isNaN(from);
    var isNumto = isNaN(to);
    if(isNumfrom == true || isNumto == true) {
        alert("Gia phai la so!");
        return false;
    }
}
// end coding implementation