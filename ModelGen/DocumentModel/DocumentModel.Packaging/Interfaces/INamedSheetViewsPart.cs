namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
public interface INamedSheetViewsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NamedSheetViews { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
