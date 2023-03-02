namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheRecordsPart
/// </summary>
public record PivotTableCacheRecordsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}