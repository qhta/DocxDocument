using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelDoc;
public class SchemaNamespace
{
  public SchemaNamespace() { }

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  [Key, Column(Order = 0)]
  public int Id { get; set; }

  [MaxLength(255)]
  public string? Url {get; set; }

  [MaxLength(10)]
  public string? Prefix { get; set; }
}
