using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace LocationMVC.Models
{
    public class Appartement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de l'appartement est obligatoire.")]
        [StringLength(100, ErrorMessage = "Le nom ne peut pas dépasser 100 caractères.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La description est obligatoire.")]
        [StringLength(500, ErrorMessage = "La description ne peut pas dépasser 500 caractères.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire.")]
        public string Address { get; set; }

        [Range(1, 20, ErrorMessage = "Le nombre de pièces doit être entre 1 et 20.")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Le prix est obligatoire.")]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être positif.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Le nom du propriétaire est obligatoire.")]
        [StringLength(100, ErrorMessage = "Le nom du propriétaire ne peut pas dépasser 100 caractères.")]
        public string OwnerName { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire.")]
        [Phone(ErrorMessage = "Le numéro de téléphone n'est pas valide.")]
        public string OwnerPhone { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateListed { get; set; }

        // Ajout de la propriété pour l'image
        public string ImagePath { get; set; }

        public Appartement()
        {
            Name = string.Empty;
            Description = string.Empty;
            Address = string.Empty;
            OwnerName = string.Empty;
            OwnerPhone = string.Empty;
            DateListed = DateTime.Now;
            ImagePath = string.Empty; // Initialisation de la propriété ImagePath
        }

        public Appartement(string name, string description, string address, string ownerName, string ownerPhone)
        {
            Name = name;
            Description = description;
            Address = address;
            OwnerName = ownerName;
            OwnerPhone = ownerPhone;
            DateListed = DateTime.Now;
            ImagePath = string.Empty; // Initialisation de la propriété ImagePath
        }
    }
}


