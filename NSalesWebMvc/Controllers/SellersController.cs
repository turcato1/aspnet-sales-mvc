﻿using Microsoft.AspNetCore.Mvc;
using NSalesWebMvc.Services;
using NSalesWebMvc.Models;

namespace NSalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellersService;

        public SellersController(SellerService sellersService)
        {
            _sellersService = sellersService;
        }

        public IActionResult Index()
        {
            var list = _sellersService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellersService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
