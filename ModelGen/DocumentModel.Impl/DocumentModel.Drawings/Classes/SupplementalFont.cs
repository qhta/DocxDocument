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
    get => (String?)OpenXmlElement?.Script?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Script = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public String? Typeface
  {
    get => (String?)OpenXmlElement?.Typeface?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Typeface = (System.String?)value;
    }
  }
  
}
