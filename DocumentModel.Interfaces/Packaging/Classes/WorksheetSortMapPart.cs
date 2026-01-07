namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetSortMapPart
/// </summary>
public interface WorksheetSortMapPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}