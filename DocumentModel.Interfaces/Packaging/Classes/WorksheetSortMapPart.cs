namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WorksheetSortMapPart
/// </summary>
public interface WorksheetSortMapPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}