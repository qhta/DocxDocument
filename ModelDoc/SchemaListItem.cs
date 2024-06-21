using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// List item type for simple list types.
/// </summary>
public class SchemaListItem
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the simple type which the list item belongs to.
  /// </summary>
  public int SimpleTypeId { get; set; }

  /// <summary>
  /// Identifier of the namespace of the item type.
  /// </summary>
  public int? ItemNamespaceId { get; set; }

  /// <summary>
  /// Name of the item type.
  /// </summary>
  [MaxLength(255)] public string? ItemTypeName { get; set; }
}
