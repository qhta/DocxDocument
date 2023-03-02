namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetSortMapPart
/// </summary>
public record WorksheetSortMapPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}