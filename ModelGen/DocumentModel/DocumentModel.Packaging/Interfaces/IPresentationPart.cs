namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PresentationPart
/// </summary>
public interface IPresentationPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets the commentParts of the PresentationPart
  /// </summary>
  public DocumentModel.Packaging.IPowerPointCommentPart? commentParts { get ; set; }
  
  /// <summary>
  /// Gets the CustomXmlParts of the PresentationPart
  /// </summary>
  public DocumentModel.Packaging.ICustomXmlPart? CustomXmlParts { get ; set; }
  
  /// <summary>
  /// Gets the FontParts of the PresentationPart
  /// </summary>
  public DocumentModel.Packaging.IFontPart? FontParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.IPresentation? Presentation { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets the SlideMasterParts of the PresentationPart
  /// </summary>
  public DocumentModel.Packaging.ISlideMasterPart? SlideMasterParts { get ; set; }
  
  /// <summary>
  /// Gets the SlideParts of the PresentationPart
  /// </summary>
  public DocumentModel.Packaging.ISlidePart? SlideParts { get ; set; }
  
}
