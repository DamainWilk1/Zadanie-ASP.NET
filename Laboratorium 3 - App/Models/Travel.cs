using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Travel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwe!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za długa nazwa! Maksymalnie 50 znaków.")]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Musisz podać miejsce początkowe wycieczki!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za długa nazwa! Maksymalnie 50 znaków.")]
        public string StartPlace { get; set; }

        [Required(ErrorMessage = "Musisz podać miejsce początkowe wycieczki!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za długa nazwa! Maksymalnie 50 znaków.")]
        public string EndPlace { get; set; }
        public int NumbParticipants { get; set; }
        [Required(ErrorMessage = "Musisz podać nazwe!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za długa nazwa! Maksymalnie 50 znaków.")]
        public string Guide { get; set; }

    }
}
