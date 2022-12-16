namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public class Color3Impl: ModelElementImpl, Color3
{
  public DocumentFormat.OpenXml.Office2013.Word.Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Color3Impl(): base() {}
  
  public Color3Impl(DocumentFormat.OpenXml.Office2013.Word.Color openXmlElement): base(openXmlElement)
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
