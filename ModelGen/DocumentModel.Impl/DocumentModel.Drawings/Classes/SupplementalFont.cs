namespace DocumentModel.Drawings;

/// <summary>
/// Font.
/// </summary>
public partial class SupplementalFontImpl: ModelElementImpl, SupplementalFont
{
  public DocumentFormat.OpenXml.Drawing.SupplementalFont? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.SupplementalFont?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SupplementalFontImpl(): base() {}
  
  public SupplementalFontImpl(DocumentFormat.OpenXml.Drawing.SupplementalFont openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Script
  /// </summary>
  public String? Script
  {
    get => (System.String?)OpenXmlElement?.Script?.Value;
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
    get => (System.String?)OpenXmlElement?.Typeface?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Typeface = (System.String?)value;
    }
  }
  
}
