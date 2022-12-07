namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public class TextWrapImpl: ModelElement<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>, TextWrap
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  public WrapKind? Type
  {
    get => (WrapKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues?)value;
    }
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public WrapSideKind? Side
  {
    get => (WrapSideKind?)OpenXmlElement?.Side?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Side = (DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorKind? AnchorX
  {
    get => (HorizontalAnchorKind?)OpenXmlElement?.AnchorX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorX = (DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public VerticalAnchorKind? AnchorY
  {
    get => (VerticalAnchorKind?)OpenXmlElement?.AnchorY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorY = (DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues?)value;
    }
  }
  
}
