using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// Simple type definition in a schema.
/// </summary>
public class SchemaSimpleType
{
  /// <summary>
  /// Unique identifier for the simple type.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the namespace where the simple type is defined.
  /// </summary>
  public int SchemaNamespaceId { get; set; }

  /// <summary>
  /// RefName of the simple type.
  /// </summary>
  [MaxLength(255)]
  public string? TypeName { get; set; }

  /// <summary>
  /// Unique identifier of the base namespace where the base type name is defined.
  /// Omitted if the base type is defined in the same namespace.
  /// </summary>
  public int? BaseNamespaceId { get; set; }

  /// <summary>
  /// RefName of the base type.
  /// </summary>
  [MaxLength(255)]
  public string? BaseTypeName { get; set; }

  /// <summary>
  /// Fixed length of the hexBinary string (in bytes).
  /// </summary>
  public int? Length { get; set; }

  /// <summary>
  /// Minimum length of the string.
  /// </summary>
  public int? MinLength { get; set; }

  /// <summary>
  /// Maximum length of the string.
  /// </summary>
  public int? MaxLength { get; set; }

  /// <summary>
  /// Minimum  inclusive value of the numeric type.
  /// </summary>
  public decimal? MinInclusive { get; set; }

  /// <summary>
  /// Maximum  inclusive value of the numeric type.
  /// </summary>
  public decimal? MaxInclusive { get; set; }

  /// <summary>
  /// Minimum exclusive value of the numeric type.
  /// </summary>
  public decimal? MinExclusive { get; set; }

  /// <summary>
  /// Maximum exclusive value of the numeric type.
  /// </summary>
  public decimal? MaxExclusive { get; set; }

  /// <summary>
  /// Navigation property for the namespace where the simple type is defined.
  /// </summary>
  public SchemaNamespace? SchemaNamespace { get; set; }
}
