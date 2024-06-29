using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Represents a group of elements which can be used in many places.
/// </summary>
public class Group
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the namespace of the group.
  /// </summary>
  public int SchemaNamespaceId { get; set; }

  /// <summary>
  /// Name of the group.
  /// </summary>
  [MaxLength(255)]
  public string? GroupName { get; set; }

  /// <summary>
  /// Navigation property for the namespace of the group.
  /// </summary>
  public Namespace? ParentNamespace { get; set; }

}
