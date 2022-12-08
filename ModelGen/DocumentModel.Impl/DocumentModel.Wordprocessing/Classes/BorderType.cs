namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public class BorderTypeImpl: ModelElementImpl, BorderType
{
  public DocumentFormat.OpenXml.Wordprocessing.BorderType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.BorderType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderKind? Val
  {
    get => (BorderKind?)OpenXmlElement?.Val?.Value;
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
    get;
    set;
  }
  
  /// <summary>
  /// Border Theme Color
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
  /// Border Theme Color Tint
  /// </summary>
  public String? ThemeTint
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  public String? ThemeShade
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public UInt32? Size
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  public UInt32? Space
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  public Boolean? Shadow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  public Boolean? Frame
  {
    get;
    set;
  }
  
}
