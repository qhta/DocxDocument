namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public partial class ColorImpl: ModelElementImpl, Color
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Color?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ColorImpl(): base() {}
  
  public ColorImpl(DocumentFormat.OpenXml.Wordprocessing.Color openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Run Content Color
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor
  {
    get => (DocumentModel.Wordprocessing.ThemeColorKind?)OpenXmlElement?.ThemeColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeColor = (DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues?)value;
    }
  }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  public String? ThemeTint
  {
    get => (System.String?)OpenXmlElement?.ThemeTint?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeTint = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  public String? ThemeShade
  {
    get => (System.String?)OpenXmlElement?.ThemeShade?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeShade = (System.String?)value;
    }
  }
  
}
