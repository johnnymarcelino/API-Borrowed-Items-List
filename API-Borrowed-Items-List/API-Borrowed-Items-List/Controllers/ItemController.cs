using API_Borrowed_Items_List.Data;
using API_Borrowed_Items_List.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace API_Borrowed_Items_List.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
