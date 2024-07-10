using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProjetoInterdisciplinar.Models;
using ProjetoInterdisciplinar.Models.ViewModels;
using ProjetoInterdisciplinar.Services;
using ProjetoInterdisciplinar.Services.Exceptions;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar.Controllers {
    public class SellersController : Controller {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService) {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
        public async Task<IActionResult> Index() {

            var list = await _sellerService.FindAllAsync();

            return View(list);
        }
        public async Task<IActionResult> Create() {

            var departments = await _departmentService.FindAllAsync();
            var viewModel = new SellerFormViewModel {
                Departments = departments
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller) {
            if (!ModelState.IsValid) {
                var departments = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            await _sellerService.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id) {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "O ID não foi inserido" });
            }
            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null) { return RedirectToAction(nameof(Error), new { message = "ID não encontrado" }); }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) {

            try {
                await _sellerService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            } catch (IntegrityException e) {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return RedirectToAction(nameof(Error), new { message = "O <strong>ID</strong> não foi inserido" });
            }
            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null) { return RedirectToAction(nameof(Error), new { message = "ID não encontrado" }); }
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return RedirectToAction(nameof(Error), new { message = "O <strong>ID</strong> não foi inserido" });
            }
            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null) {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado" });
            }

            List<Department> departments = await _departmentService.FindAllAsync();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller) {
            if (!ModelState.IsValid) {
                var departments = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            if (id != seller.Id) {
                return RedirectToAction(nameof(Error), new { message = "Incompatibilidade de ID" });
            }
            try {
                await _sellerService.UpdateAsync(seller);
                return RedirectToAction(nameof(Index));
            } catch (NotFoundException e) {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            } catch (DbConcurrencyException e) {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message) {

            var viewModel = new ErrorViewModel {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

    }
}
