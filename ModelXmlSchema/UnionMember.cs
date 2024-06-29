using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Union member type for the simple type.
/// </summary>
public class UnionMember
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the simple type which the union member belongs to.
  /// </summary>
  public int SimpleTypeId { get; set; }

  /// <summary>
  /// Identifier of the namespace of the member type.
  /// </summary>
  public int? MemberNamespaceId { get; set; }

  /// <summary>
  /// RefName of the member type.
  /// </summary>
  [MaxLength(255)] public string? MemberTypeName { get; set; }
}
