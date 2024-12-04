using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LocationMVC.Models;
using LocationMVC.Services;
using LocationMVC.Services.Repositories;

namespace LocationMVC.Controllers
{
    public class AppartementsController : Controller
    {
        private readonly IRepository<Appartement> _appartementRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AppartementsController(IRepository<Appartement> appartementRepository, IWebHostEnvironment webHostEnvironment)
        {
            _appartementRepository = appartementRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Appartements
        public async Task<IActionResult> Index()
        {
            var appartements = await _appartementRepository.GetAllAsync();
            return View(appartements);
        }

        // GET: Appartements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appartement = await _appartementRepository.GetByIdAsync(id.Value);
            if (appartement == null)
            {
                return NotFound();
            }

            return View(appartement);
        }

        // GET: Appartements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appartements/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Address,NumberOfRooms,Price,OwnerName,OwnerPhone,DateListed")] Appartement appartement, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    string imageFileName = ProcessImageFile(Image);
                    appartement.ImagePath = "/images/" + imageFileName;
                }

                await _appartementRepository.AddAsync(appartement);
                return RedirectToAction(nameof(Index));
            }
            return View(appartement);
        }

        // GET: Appartements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appartement = await _appartementRepository.GetByIdAsync(id.Value);
            if (appartement == null)
            {
                return NotFound();
            }
            return View(appartement);
        }

        // POST: Appartements/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Address,NumberOfRooms,Price,OwnerName,OwnerPhone,DateListed,ImagePath")] Appartement appartement, IFormFile Image)
        {
            if (id != appartement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    string imageFileName = ProcessImageFile(Image);

                    // Supprimer l'ancienne image si nécessaire
                    if (!string.IsNullOrEmpty(appartement.ImagePath))
                    {
                        DeleteOldImage(appartement.ImagePath);
                    }

                    // Mettre à jour le chemin de la nouvelle image
                    appartement.ImagePath = "/images/" + imageFileName;
                }

                await _appartementRepository.UpdateAsync(appartement);
                return RedirectToAction(nameof(Index));
            }
            return View(appartement);
        }

        // GET: Appartements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appartement = await _appartementRepository.GetByIdAsync(id.Value);
            if (appartement == null)
            {
                return NotFound();
            }

            return View(appartement);
        }

        // POST: Appartements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appartement = await _appartementRepository.GetByIdAsync(id);
            if (appartement != null)
            {
                if (!string.IsNullOrEmpty(appartement.ImagePath))
                {
                    DeleteOldImage(appartement.ImagePath);
                }

                await _appartementRepository.DeleteAsync(appartement);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool AppartementExists(int id)
        {
            return _appartementRepository.GetByIdAsync(id) != null;
        }

        private string ProcessImageFile(IFormFile image)
        {
            string fileName = Path.GetFileNameWithoutExtension(image.FileName);
            string extension = Path.GetExtension(image.FileName);
            string imageFileName = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + extension;
            string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "images", imageFileName);

            using (var fileStream = new FileStream(uploadPath, FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            return imageFileName;
        }

        private void DeleteOldImage(string imagePath)
        {
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, imagePath.TrimStart('/'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }
        }
    }
}

