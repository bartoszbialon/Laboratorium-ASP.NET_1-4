using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3_i_4.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")] Low = 1,
        [Display(Name = "Normalny")] Medium = 2,
        [Display(Name = "Wysoki")] High = 3,
        [Display(Name = "Pilny")] Urgent = 4
    }

    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz wpisać imię")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imię, maksymalnie 100 znaków")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Musisz podać adres email")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        [Display(Name = "Adres email")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }

        [Display(Name = "Data urodzenia")]
        public DateTime Birth { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
