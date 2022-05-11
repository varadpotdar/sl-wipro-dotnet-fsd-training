using System.ComponentModel.DataAnnotations;

public class Book
{
    public int Id { get; set; }

    [Display(Name = "Book Title")]
    [Required]
    public string Title { get; set; }

    public string? Genre { get; set; }

    [DataType(DataType.Currency)]
    [Range(1, 10000)]
    public decimal Price { get; set; }

    [Display(Name = "Publish Date")]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }
}