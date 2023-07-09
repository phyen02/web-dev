function validate() {
    var u = document.getElementById("email").value;
    var p1 = document.getElementById("id").value;
    var p2 = document.getElementById("password").value;
    let isEmailAddress = u => {
        return /^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$/.test(u) || /w+([-+.]w+)*@w+([-.]w+)*.w+([-.]w+)*/.test(u);
    }
    if(u== "" || isEmailAddress(u)==false ) {
    alert("Vui lòng nhập email đúng định dạng!");
    return false;
    }
    if(p1 == "" || p1.length <6) {
    alert("ID phải từ 6 kí tự!");
    return false;
    }

    if(p2 == "" || p1.length <6) {
    alert("Password phải từ 6 kí tự!");
    return false;
    }
    return true;
}