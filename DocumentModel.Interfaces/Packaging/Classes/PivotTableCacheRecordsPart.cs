namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheRecordsPart
/// </summary>
public interface PivotTableCacheRecordsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}