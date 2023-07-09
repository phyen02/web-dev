using LAB3.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LAB3.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listType = new List<Type>() {
            new Type(){ID="0",Name="-- Chọn Loại Hình --"},
            new Type(){ID="1",Name="Đơn vị sự nghiệp nhà nước"},
            new Type(){ID="2",Name="Doanh nghiệp tư nhân"},
            new Type(){ID="3",Name="Công ty hợp danh"},
            new Type(){ID="4",Name="Công ty TNHH một thành viên"},
            new Type(){ID="5",Name="Công ty trách nhiệm hữu hạn có hai thành viên trở lên"},
            new Type(){ID="6",Name="Công ty cổ phần"},
};
            return View();
        }
        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            string fvr = "";
            TempData["Name"] = Request["txtName"];
            TempData["Type"] = Request["Type"];
            TempData["Quantity"] = Request["txtQuantity"];
            TempData["Address"] = Request["txtAddress"];
            TempData["Contact"] = Request["txtContact"];
            TempData["Phone"] = Request["txtPhone"];
            TempData["Fax"] = Request["txtFax"];
            TempData["Email"] = Request["txtEmail"];
            TempData["WebAddress"] = Request["txtWebAddress"];
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["Receive"] = Request["rabReceive"];
            return View();
        }
    }
}