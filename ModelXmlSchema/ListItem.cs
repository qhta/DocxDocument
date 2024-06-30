using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// List item type for simple list types.
/// </summary>
public class ListItem
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the simple type which the list item belongs to.
  /// </summary>
  public int OwnerTypeId { get; set; }

  /// <summary>
  /// Identifier of the member type.
  /// </summary>
  public int MemberTypeId { get; set; }

  /// <summary>
  /// Navigation property for the owner type.
  /// </summary>
  [Required]
  public SimpleType OwnerType { get; set; } = null!;

  /// <summary>
  /// Navigation property for the member type.
  /// </summary>
  public SimpleType MemberType { get; set; } = null!;
}
