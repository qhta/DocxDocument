namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public partial class FramePropertiesImpl: ModelElementImpl, FrameProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.FrameProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FrameProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FramePropertiesImpl(): base() {}
  
  public FramePropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.FrameProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DocumentModel.Wordprocessing.DropCapLocationKind? DropCap
  {
    get => (DocumentModel.Wordprocessing.DropCapLocationKind?)OpenXmlElement?.DropCap?.Value;
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
    get => (System.Int32?)OpenXmlElement?.Lines?.Value;
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
    get => (System.String?)OpenXmlElement?.Width?.Value;
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
    get => (System.UInt32?)OpenXmlElement?.Height?.Value;
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
    get => (System.String?)OpenXmlElement?.VerticalSpace?.Value;
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
    get => (System.String?)OpenXmlElement?.HorizontalSpace?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalSpace = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public DocumentModel.Wordprocessing.TextWrappingKind? Wrap
  {
    get => (DocumentModel.Wordprocessing.TextWrappingKind?)OpenXmlElement?.Wrap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Wrap = (DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues?)value;
    }
  }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchorKind? HorizontalPosition
  {
    get => (DocumentModel.Wordprocessing.HorizontalAnchorKind?)OpenXmlElement?.HorizontalPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalPosition = (DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchorKind? VerticalPosition
  {
    get => (DocumentModel.Wordprocessing.VerticalAnchorKind?)OpenXmlElement?.VerticalPosition?.Value;
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
    get => (System.String?)OpenXmlElement?.X?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.X = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignmentKind? XAlign
  {
    get => (DocumentModel.Wordprocessing.HorizontalAlignmentKind?)OpenXmlElement?.XAlign?.Value;
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
    get => (System.String?)OpenXmlElement?.Y?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Y = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignmentKind? YAlign
  {
    get => (DocumentModel.Wordprocessing.VerticalAlignmentKind?)OpenXmlElement?.YAlign?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.YAlign = (DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public DocumentModel.Wordprocessing.HeightRuleKind? HeightType
  {
    get => (DocumentModel.Wordprocessing.HeightRuleKind?)OpenXmlElement?.HeightType?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AnchorLock?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorLock = (System.Boolean?)value;
    }
  }
  
}
