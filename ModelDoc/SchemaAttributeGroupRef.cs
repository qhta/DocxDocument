using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaAttributeGroupRef
{

  [Key] public int Id { get; set; }

  public int? ComplexTypeId { get; set; }

  public int? AttributeGroupId { get; set; }

  public int? SchemaFileId { get; set; }

  public int? RefNamespaceId { get; set; }

  [MaxLength(255)]
  public string? GroupName { get; set; }

}
