using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchTerm { get; set; }

    }
}
