namespace DocumentModel.Drawings;

/// <summary>
/// Font.
/// </summary>
public class SupplementalFontImpl: ModelElementImpl, SupplementalFont
{
  public DocumentFormat.OpenXml.Drawing.SupplementalFont? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.SupplementalFont?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Script
  /// </summary>
  public String? Script
  {
    get;
    set;
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public String? Typeface
  {
    get;
    set;
  }
  
}
