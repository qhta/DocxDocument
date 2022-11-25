namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TableStylesPart
/// </summary>
public interface ITableStylesPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawing.ITableStyleList? TableStyleList { get ; set; }
  
}
