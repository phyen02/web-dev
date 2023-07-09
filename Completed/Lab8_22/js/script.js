function getValue(id){
  return document.getElementById(id).value.trim();
}
function validate() {
  var email = getValue('email');
  var at = email.indexOf("@");
  var dot = email.lastIndexOf(".");
  if((at<1) || (dot<at+2) || (dot+2>email.length)) {
      alert("Email khong hop le! (vi du: abc@email.com)");
      email.focus();
      return false;
  }
  alert("Đã nhận được thông tin!");
}  
