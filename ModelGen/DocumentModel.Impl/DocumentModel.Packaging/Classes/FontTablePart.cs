namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public class FontTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, FontTablePart
{
  public new DocumentFormat.OpenXml.Packaging.FontTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.FontTablePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public FontPart? FontParts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Fonts? Fonts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
