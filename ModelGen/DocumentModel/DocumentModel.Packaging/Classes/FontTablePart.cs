namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontTablePart
/// </summary>
public class FontTablePart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the FontParts of the FontTablePart
  /// </summary>
  public OpenXmlPartContainer? FontParts
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
  
}
