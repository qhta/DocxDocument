using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaSimpleType
{
  [Key] public int Id { get; set; }

  public int SchemaNamespaceId { get; set; }

  [MaxLength(255)]
  public string? TypeName { get; set; }

  public int? BaseNamespaceId { get; set; }

  [MaxLength(255)]
  public string? BaseTypeName { get; set; }

  public int? MinLength { get; set; }

  public int? Length { get; set; }

  public int? MaxLength { get; set; }

  public decimal? MinExclusive { get; set; }

  public decimal? MinInclusive { get; set; }

  public decimal? MaxInclusive { get; set; }

  public decimal? MaxExclusive { get; set; }

  public SchemaNamespace? SchemaNamespace { get; set; }
}
