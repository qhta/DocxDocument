namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ControlPropertiesPart
/// </summary>
public interface IControlPropertiesPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.IFormControlProperties? FormControlProperties { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
