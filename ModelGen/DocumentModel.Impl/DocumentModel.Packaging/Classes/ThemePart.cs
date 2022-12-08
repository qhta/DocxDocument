namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemePart
/// </summary>
public class ThemePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ThemePart
{
  public new DocumentFormat.OpenXml.Packaging.ThemePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ThemePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemePart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.Theme? Theme
  {
    get;
    set;
  }
  
}
