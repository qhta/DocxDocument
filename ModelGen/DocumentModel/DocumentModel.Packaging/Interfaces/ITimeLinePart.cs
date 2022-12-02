namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public interface ITimeLinePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.ITimelines? Timelines { get ; set; }
  
}
