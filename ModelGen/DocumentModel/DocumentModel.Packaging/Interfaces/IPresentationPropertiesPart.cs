namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PresentationPropertiesPart
/// </summary>
public interface IPresentationPropertiesPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.IPresentationProperties? PresentationProperties { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
