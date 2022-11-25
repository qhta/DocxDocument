namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ViewPropertiesPart
/// </summary>
public interface IViewPropertiesPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the ViewPropertiesPart
  /// </summary>
  public DocumentModel.Packaging.ISlidePart? SlideParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.IViewProperties? ViewProperties { get ; set; }
  
}
