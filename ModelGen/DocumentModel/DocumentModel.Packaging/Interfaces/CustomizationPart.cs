namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
[ContentMime("application/vnd.ms-word.keyMapCustomizations+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations")]
[PartConstraint(typeof(DocumentModel.Packaging.WordAttachedToolbarsPart), false, false)]
public interface CustomizationPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup { get ; set; }
  
}
