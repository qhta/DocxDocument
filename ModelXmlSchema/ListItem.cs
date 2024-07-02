using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// List item type for simple list types.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(MemberTypeId), IsUnique = true)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(MemberTypeId), IsUnique = false)]
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
