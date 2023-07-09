using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_3.Models;

namespace Lab2_3.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        List<Song> listSong = new List<Song>();
        public ActionResult ListMusic()
        {
            listSong = initializeSong();
            ViewBag.listSong = listSong;
            return View();
        }

        public FilePathResult Download()
        {
            string songFile = "seetinh.mp3";
            string pathFile = Server.MapPath("~/Content/seetinh.mp3");
            return File(pathFile, "music/mp3", songFile);
        }

        public ActionResult DetailsMusic(string musicName, int? musicId)
        {
            return View();
        }

        private List<Song> initializeSong()
        {
            return new List<Song>()
            {
                new Song {Id = "1", Name = "Ai Hãy Chữ Ngờ", Author = "Lâm Chấn Khang" },
                new Song {Id = "2", Name = "Ai Rồi Cũng Khác", Author = "Hamlet Truong" },
                new Song {Id = "3", Name = "Anh Ở Đâu", Author = "Trang Pháp" },
                new Song {Id = "4", Name = "Anh Biết", Author = "Hồ Quang Hiếu" },
                new Song {Id = "5", Name = "Anh Biết", Author = "Tim" },
                new Song {Id = "6", Name = "Anh Ghét Làm Bạn Em", Author = "Phan Mạnh Quỳnh" },
                new Song {Id = "7", Name = "Anh Cần Em", Author = "Khắc Việt" },
                new Song {Id = "8", Name = "Anh Chỉ Là Người Em Từng Yêu", Author = "Khắc Anh" },
                new Song {Id = "9", Name = "Anh Đã Sai", Author = "OnlyC" }
            };
        }
    }
}