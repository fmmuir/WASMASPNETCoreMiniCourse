

using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

//sealed means class cannot be inherited from
public sealed class Post
{
    [Key]
    public int PostId { get; set; } = 0;

    [Required]
    [MaxLength(length: 100)]
    public string Title { get; set; } = string.Empty; /*this can never be null hence string.empty*/

    [Required]
    [MaxLength(length: 10000)]
    public string Content { get; set; } = string.Empty; /*this can never be null hence string.empty*/

}

