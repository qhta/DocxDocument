namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public partial class BorderTypeImpl: ModelElementImpl, BorderType
{
  public DocumentFormat.OpenXml.Wordprocessing.BorderType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.BorderType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BorderTypeImpl(): base() {}
  
  public BorderTypeImpl(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Wordprocessing.BorderKind? Val
  {
    get => (DocumentModel.Wordprocessing.BorderKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.BorderValues?)value;
    }
  }
  
  /// <summary>
  /// Border Color
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
  /// Border Theme Color
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
  /// Border Theme Color Tint
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
  /// Border Theme Color Shade
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
  
  /// <summary>
  /// Border Width
  /// </summary>
  public UInt32? Size
  {
    get => (System.UInt32?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  public UInt32? Space
  {
    get => (System.UInt32?)OpenXmlElement?.Space?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Space = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  public Boolean? Shadow
  {
    get => (System.Boolean?)OpenXmlElement?.Shadow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Shadow = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  public Boolean? Frame
  {
    get => (System.Boolean?)OpenXmlElement?.Frame?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Frame = (System.Boolean?)value;
    }
  }
  
}
