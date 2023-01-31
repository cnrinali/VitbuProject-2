﻿using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using VitbuWebUIPartnerPanel.Models;

namespace VitbuWebUIKurumsalPanel.Controllers
{
    public class CustomerController : Controller
    {
        IUserService _userService;
        ICustomerService _customerService;
        public CustomerController(IUserService userService, ICustomerService customerService)
        {
            _userService = userService;
            _customerService = customerService;
        }

        [HttpGet, Route("superadmin/customerlist")]
        public IActionResult CustomerList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Customers = _customerService.GetAll()
            };
            return View(model);
        }

        [HttpPost, Route("superadmin/customeredit")]
        public IActionResult CustomerEdit(Customer customer)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _customerService.Update(customer);

            return Ok("Başarılı!");
        }

        [HttpPost, Route("superadmin/customermodaladd")]
        public IActionResult CustomerModalAdd(Customer customer)
        {
            Customer model = new Customer()
            {
                Ad = customer.Ad,
                Soyad = customer.Soyad,
                Cinsiyet = customer.Cinsiyet,
                Email = customer.Email,
                KimlikNo = customer.KimlikNo,
                PasaportNo = customer.PasaportNo,
                Sms = "true",
                Telefon = customer.Telefon,
                Uyruk = customer.Uyruk,
                StatusId = "1"
            };
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _customerService.Create(model);

            return Ok(model);
        }
        public IActionResult DeleteCustomer(Guid id)
        {
            var entity = _customerService.GetById(id);

            if (entity != null)
            {
                _customerService.Delete(entity);
            }

            return RedirectToAction("CustomerList");
        }
    }
}
