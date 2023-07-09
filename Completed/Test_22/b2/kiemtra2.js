    
function validate() {
    var u = document.getElementById("email").value;
    var p1 = document.getElementById("id").value;
    var p2 = document.getElementById("password").value;

    if(u != "6151071016@st.utc2.edu.vn") {
    alert("Email sai thông tin!");
    return false;
    }
    if(p1 != "6151071031") {
    alert("ID sai thông tin!");
    return false;
    }

    if(p2 != "6151071031") {
    alert("Password sai thông tin!");
    return false;
    }  
    return true;
}