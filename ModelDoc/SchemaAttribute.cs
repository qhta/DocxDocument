using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaAttribute
{

  [Key] public int Id { get; set; }

  public int? ComplexTypeId { get; set; }

  public int? AttributeGroupId { get; set; }

  public int? SchemaNamespaceId { get; set; }

  public int? RefNamespaceId { get; set; }

  [MaxLength(255)]
  public string? AttributeName { get; set; }

  public int? TypeNamespaceId { get; set; }

  [MaxLength(255)]
  public string? TypeName { get; set; }

  public AttributeUse? Use { get; set; }

  [MaxLength(255)]
  public string? DefaultValue { get; set; }

  public bool IsFixed { get; set; }

}
