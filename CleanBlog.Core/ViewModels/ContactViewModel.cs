using System.ComponentModel.DataAnnotations;

namespace CleanBlog.Core.ViewModels
{
    public class ContactViewModel
    {
        private string name;
        private string email;
        private string message;
        private int contactFormmId;

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get => name; set => name = value; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "Please enter your message")]
        [MaxLength(500, ErrorMessage = "Your message must be no longer than 500 characters")]
        public string Message { get => message; set => message = value; }

        public int ContactFormmId { get => contactFormmId; set => contactFormmId = value; }
    }
}
