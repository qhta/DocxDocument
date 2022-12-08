namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public class FontReference1Impl: ModelElementImpl, FontReference1
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public FontCollectionIndexKind? Index
  {
    get => (FontCollectionIndexKind?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues?)value;
    }
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers
  {
    get;
    set;
  }
  
  public RgbColorModelPercentage? RgbColorModelPercentage
  {
    get;
    set;
  }
  
  public RgbColorModelHex? RgbColorModelHex
  {
    get;
    set;
  }
  
  public HslColor? HslColor
  {
    get;
    set;
  }
  
  public SystemColor? SystemColor
  {
    get;
    set;
  }
  
  public SchemeColor? SchemeColor
  {
    get;
    set;
  }
  
  public PresetColor? PresetColor
  {
    get;
    set;
  }
  
  public StyleColor? StyleColor
  {
    get;
    set;
  }
  
}
