namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public class DocumentBackgroundImpl: ModelElementImpl, DocumentBackground
{
  public DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentBackground?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocumentBackgroundImpl(): base() {}
  
  public DocumentBackgroundImpl(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// color
  /// </summary>
  public String? Color
  {
    get => (String?)OpenXmlElement?.Color?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color = (System.String?)value;
    }
  }
  
  /// <summary>
  /// themeColor
  /// </summary>
  public ThemeColorKind? ThemeColor
  {
    get => (ThemeColorKind?)OpenXmlElement?.ThemeColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeColor = (DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues?)value;
    }
  }
  
  /// <summary>
  /// themeTint
  /// </summary>
  public String? ThemeTint
  {
    get => (String?)OpenXmlElement?.ThemeTint?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeTint = (System.String?)value;
    }
  }
  
  /// <summary>
  /// themeShade
  /// </summary>
  public String? ThemeShade
  {
    get => (String?)OpenXmlElement?.ThemeShade?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeShade = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
