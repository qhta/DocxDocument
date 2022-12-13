namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public class UnderlineImpl: ModelElementImpl, Underline
{
  public DocumentFormat.OpenXml.Wordprocessing.Underline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Underline?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UnderlineImpl(): base() {}
  
  public UnderlineImpl(DocumentFormat.OpenXml.Wordprocessing.Underline openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Underline Style
  /// </summary>
  public DocumentModel.Wordprocessing.UnderlineKind? Val
  {
    get => (DocumentModel.Wordprocessing.UnderlineKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.UnderlineValues?)value;
    }
  }
  
  /// <summary>
  /// Underline Color
  /// </summary>
  public String? Color
  {
    get => (System.String?)OpenXmlElement?.Color?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Underline Theme Color
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
  /// Underline Theme Color Tint
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
  /// Underline Theme Color Shade
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
