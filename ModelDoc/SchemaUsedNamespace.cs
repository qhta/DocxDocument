using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDoc;
public class SchemaUsedNamespace
{
  public SchemaUsedNamespace() { }

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  [Key, Column(Order = 0)]
  public int Id { get; set; }

  public int SchemaFileId {get; set; }

  public int SchemaNamespaceId { get; set; }

  [MaxLength(10)]
  public string? Prefix { get; set; }
}
