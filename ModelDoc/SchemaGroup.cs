using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaGroup
{

  [Key] public int Id { get; set; }

  public int SchemaNamespaceId { get; set; }

  [MaxLength(255)]
  public string? GroupName { get; set; }

  /// <summary>
  /// Navigation property for the namespace of the group.
  /// </summary>
  public SchemaNamespace? ParentNamespace { get; set; }

}
