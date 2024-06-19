using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaAttributeGroup
{

  [Key] public int Id { get; set; }

  public int SchemaFileId { get; set; }

  [MaxLength(255)]
  public string? GroupName { get; set; }


}
