namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public class BodyPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.BodyProperties>, BodyProperties
{
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public TextVerticalOverflowKind? VerticalOverflow
  {
    get => (TextVerticalOverflowKind?)OpenXmlElement?.VerticalOverflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalOverflow = (DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues?)value;
    }
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflowKind? HorizontalOverflow
  {
    get => (TextHorizontalOverflowKind?)OpenXmlElement?.HorizontalOverflow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalOverflow = (DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues?)value;
    }
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public TextVerticalKind? Vertical
  {
    get => (TextVerticalKind?)OpenXmlElement?.Vertical?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Vertical = (DocumentFormat.OpenXml.Drawing.TextVerticalValues?)value;
    }
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public TextWrappingKind? Wrap
  {
    get => (TextWrappingKind?)OpenXmlElement?.Wrap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Wrap = (DocumentFormat.OpenXml.Drawing.TextWrappingValues?)value;
    }
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public TextAnchoringKind? Anchor
  {
    get => (TextAnchoringKind?)OpenXmlElement?.Anchor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Anchor = (DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public PresetTextWrap? PresetTextWrap
  {
    get;
    set;
  }
  
  public NormalAutoFit? NormalAutoFit
  {
    get;
    set;
  }
  
  public Scene3DType? Scene3DType
  {
    get;
    set;
  }
  
  public Shape3DType? Shape3DType
  {
    get;
    set;
  }
  
  public FlatText? FlatText
  {
    get;
    set;
  }
  
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
