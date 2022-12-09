namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public class FramePropertiesImpl: ModelElementImpl, FrameProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.FrameProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FrameProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  public Int32? Lines
  {
    get => (Int32?)OpenXmlElement?.Lines?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Lines = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public String? Width
  {
    get => (String?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public UInt32? Height
  {
    get => (UInt32?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public String? VerticalSpace
  {
    get => (String?)OpenXmlElement?.VerticalSpace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalSpace = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public String? HorizontalSpace
  {
    get => (String?)OpenXmlElement?.HorizontalSpace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalSpace = (System.String?)value;
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
  /// Absolute Horizontal Position
  /// </summary>
  public String? X
  {
    get => (String?)OpenXmlElement?.X?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.X = (System.String?)value;
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
  /// Absolute Vertical Position
  /// </summary>
  public String? Y
  {
    get => (String?)OpenXmlElement?.Y?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Y = (System.String?)value;
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
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  public Boolean? AnchorLock
  {
    get => (Boolean?)OpenXmlElement?.AnchorLock?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorLock = (System.Boolean?)value;
    }
  }
  
}
