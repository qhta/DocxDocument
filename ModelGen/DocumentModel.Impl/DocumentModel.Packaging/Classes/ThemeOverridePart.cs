namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ThemeOverridePart
/// </summary>
public class ThemeOverridePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ThemeOverridePart
{
  public new DocumentFormat.OpenXml.Packaging.ThemeOverridePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ThemeOverridePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ThemeOverridePart
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
  public DocumentModel.Drawings.ThemeOverride? ThemeOverride
  {
    get;
    set;
  }
  
}
