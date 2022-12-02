namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public interface ISlicersPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.ISlicers? Slicers { get ; set; }
  
}
