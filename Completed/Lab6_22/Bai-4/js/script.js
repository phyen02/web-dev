// coding implementation
function getValue(id){
    return document.getElementById(id).value.trim();
}
function validate() {
    var rating = getValue('rate');
    var isNum = isNaN(rating);
    if(isNum == true) {
        alert("Rating phai la so!");
        rating.focus();
        return false;
    }
    var email = getValue('email');
    var at = email.indexOf("@");
    var dot = email.lastIndexOf(".");
    if((at<1) || (dot<at+2) || (dot+2>email.length)) {
        alert("Email khong hop le! (vi du: abc@email.com)");
        email.focus();
        return false;
    }
    var com = getValue('com');
    if(com.length>30) {
        alert("Vui long kiem tra lai comment! (toi da 30 ky tu)");
        com.focus();
        return false;
    }
}  
// end coding implementation