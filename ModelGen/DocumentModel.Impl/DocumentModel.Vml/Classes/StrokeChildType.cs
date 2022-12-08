namespace DocumentModel.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public class StrokeChildTypeImpl: ModelElementImpl, StrokeChildType
{
  public DocumentFormat.OpenXml.Vml.Office.StrokeChildType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.StrokeChildType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public Boolean? On
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public String? Weight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public String? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public String? Color2
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public String? Opacity
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public StrokeLineStyleKind? LineStyle
  {
    get => (StrokeLineStyleKind?)OpenXmlElement?.LineStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LineStyle = (DocumentFormat.OpenXml.Vml.StrokeLineStyleValues?)value;
    }
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public Decimal? MiterLimit
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public StrokeJoinStyleKind? JoinStyle
  {
    get => (StrokeJoinStyleKind?)OpenXmlElement?.JoinStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.JoinStyle = (DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public StrokeEndCapKind? EndCap
  {
    get => (StrokeEndCapKind?)OpenXmlElement?.EndCap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndCap = (DocumentFormat.OpenXml.Vml.StrokeEndCapValues?)value;
    }
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public String? DashStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? InsetPen
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public FillKind? FillType
  {
    get => (FillKind?)OpenXmlElement?.FillType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FillType = (DocumentFormat.OpenXml.Vml.FillTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public String? Source
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? ImageAspect
  {
    get => (ImageAspectKind?)OpenXmlElement?.ImageAspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageAspect = (DocumentFormat.OpenXml.Vml.ImageAspectValues?)value;
    }
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public String? ImageSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public Boolean? ImageAlignShape
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public StrokeArrowKind? StartArrow
  {
    get => (StrokeArrowKind?)OpenXmlElement?.StartArrow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartArrow = (DocumentFormat.OpenXml.Vml.StrokeArrowValues?)value;
    }
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public StrokeArrowWidthKind? StartArrowWidth
  {
    get => (StrokeArrowWidthKind?)OpenXmlElement?.StartArrowWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartArrowWidth = (DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues?)value;
    }
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public StrokeArrowLengthKind? StartArrowLength
  {
    get => (StrokeArrowLengthKind?)OpenXmlElement?.StartArrowLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartArrowLength = (DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public StrokeArrowKind? EndArrow
  {
    get => (StrokeArrowKind?)OpenXmlElement?.EndArrow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndArrow = (DocumentFormat.OpenXml.Vml.StrokeArrowValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public StrokeArrowWidthKind? EndArrowWidth
  {
    get => (StrokeArrowWidthKind?)OpenXmlElement?.EndArrowWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndArrowWidth = (DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public StrokeArrowLengthKind? EndArrowLength
  {
    get => (StrokeArrowLengthKind?)OpenXmlElement?.EndArrowLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndArrowLength = (DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues?)value;
    }
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public String? Href
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public String? AlternateImageReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public String? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash
  {
    get;
    set;
  }
  
}
