using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelDoc;
public class SchemaFile
{
  public SchemaFile() { }

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  [Key, Column(Order = 0)]
  public int Id { get; set; }

  [MaxLength(255)]
  public string? FileName {get; set; }

  public int? TargetNamespaceId { get; set; }

  public SchemaNamespace? TargetNamespace
  {
    get; set;
  }

  //public Types Types {get; set;} = new();
}
