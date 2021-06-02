using System;
using System.Web;
using DeepOTools.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOWebApp.Controllers
{
    public class InventoryController : Controller
    {
        private IInventoryRepository repository;
        public InventoryController(IInventoryRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Inventories);
    }
}
