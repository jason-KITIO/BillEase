// Controllers/ClientsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BillEase.Data;
using BillEase.Models;
using X.PagedList;

namespace BillEase.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const int PageSize = 5; // Nombre d'éléments par page

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            if (!ModelState.IsValid)
            {
                if (_context.Clients.Any(c => c.Id == client.Id))
                {
                    ViewBag.Erreur = "Ce client existe déjà.";
                    return View(client);
                }
                _context.Clients.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clients/Edit/5
        public IActionResult Edit(int id)
        {
            Client client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
            {
                return View("NotFound");
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Client client)
        {
            if (_context.Clients.Any(c => c.Id == client.Id))
            {
                _context.Clients.Update(client);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Erreur = "Ce client n'existe pas.";
            return RedirectToAction("Index");
        }

        // GET: Clients/Details/5
        public IActionResult Details(int id)
        {
            var clientDetails = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (clientDetails == null)
            {
                return View("NotFound");
            }
            return View(clientDetails);
        }

        // GET: Clients/Delete/5
        public IActionResult Delete(int id)
        {
            Client client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(Client client)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Clients/Index

        public async Task<IActionResult> Index(string searchString, int? page)
        {
            var clients = _context.Clients.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                clients = clients.Where(c => c.Nom.Contains(searchString));
            }

            int pageNumber = page ?? 1;
            int totalItems = await clients.CountAsync();
            int totalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

            var pagedClients = await clients
                .Skip((pageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();

            ViewBag.SearchString = searchString;
            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = totalPages;

            return View(pagedClients);
        }
    }
}
