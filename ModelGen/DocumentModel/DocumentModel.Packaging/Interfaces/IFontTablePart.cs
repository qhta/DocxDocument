namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public interface IFontTablePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public IFontPart? FontParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.IFonts? Fonts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
