namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public class FramePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>, FrameProperties
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DropCapLocationKind? DropCap
  {
    get => (DropCapLocationKind?)OpenXmlElement?.DropCap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DropCap = (DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues?)value;
    }
  }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public TextWrappingKind? Wrap
  {
    get => (TextWrappingKind?)OpenXmlElement?.Wrap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Wrap = (DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues?)value;
    }
  }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorKind? HorizontalPosition
  {
    get => (HorizontalAnchorKind?)OpenXmlElement?.HorizontalPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalPosition = (DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public VerticalAnchorKind? VerticalPosition
  {
    get => (VerticalAnchorKind?)OpenXmlElement?.VerticalPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalPosition = (DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public HorizontalAlignmentKind? XAlign
  {
    get => (HorizontalAlignmentKind?)OpenXmlElement?.XAlign?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.XAlign = (DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public VerticalAlignmentKind? YAlign
  {
    get => (VerticalAlignmentKind?)OpenXmlElement?.YAlign?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.YAlign = (DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public HeightRuleKind? HeightType
  {
    get => (HeightRuleKind?)OpenXmlElement?.HeightType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HeightType = (DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues?)value;
    }
  }
  
}
