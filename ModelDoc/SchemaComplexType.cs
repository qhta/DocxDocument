using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaComplexType
{
  [Key] public int Id { get; set; }

  public int SchemaNamespaceId { get; set; }

  [MaxLength(255)]
  public string? TypeName { get; set; }

  public int? BaseNamespaceId { get; set; }

  [MaxLength(255)]
  public string? BaseTypeName { get; set; }

  public ContentType ContentType { get; set; }
}
