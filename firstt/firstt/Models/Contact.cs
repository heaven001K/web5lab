using System.ComponentModel.DataAnnotations;

namespace firstt.Models
{
    public class Contact
    {
        [Display(Name="enter a name")]
        [Required(ErrorMessage = "enter a fielf")]
        public string Name { get; set; } = "";

        [Display(Name = "enter a surname")]
        public string surName { get; set; } = "";

        [Display(Name = "enter your age")]
        public int  age { get; set; }

        [Display(Name = "enter a phone number")]
        public string phoneNumber { get; set; } = "";

    }
}
