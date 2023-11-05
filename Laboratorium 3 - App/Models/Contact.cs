using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Laboratorium_3___App.Models
{
    static public class EnumExtension
    {
        static public string GetDisplayName(this Enum e)
        {
            return
                e.GetType()
                .GetMember(e.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>().GetName();
        }
    }
    public enum Priority
    {
        [Display(Name = "niski")]
        Low,
        [Display(Name = "normalny")]
        Normal,
        [Display(Name = "pilny")]
        Urgent
    }
    public class Contact
    {
        // Usuń atrybut HiddenInput
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        // Pozostałe właściwości
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "imię")]
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Imię zbyt długie maksymalnie 50 znaków")]
        public string Name { get; set; }
        [Display(Name = "email")]
        [EmailAddress(ErrorMessage = "Musissz podać poprawny email! (Brak znaku: @)")]
        public string Email { get; set; }
        [Display(Name = "numer telefonu")]
        [Phone(ErrorMessage = "Numer telefonu powinien zawierać cyfry")]
        public string Phone { get; set; }
        [Display(Name = "data urodzin")]
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }
    }
}