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
  
  public StrokeChildTypeImpl(): base() {}
  
  public StrokeChildTypeImpl(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
    get => (Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public String? Weight
  {
    get => (String?)OpenXmlElement?.Weight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Weight = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Stroke Color
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
  /// Stroke Alternate Pattern Color
  /// </summary>
  public String? Color2
  {
    get => (String?)OpenXmlElement?.Color2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public String? Opacity
  {
    get => (String?)OpenXmlElement?.Opacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Opacity = (System.String?)value;
    }
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
    get => (Decimal?)OpenXmlElement?.MiterLimit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MiterLimit = (System.Decimal?)value;
    }
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
    get => (String?)OpenXmlElement?.DashStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DashStyle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? InsetPen
  {
    get => (Boolean?)OpenXmlElement?.InsetPen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetPen = (System.Boolean?)value;
    }
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
    get => (String?)OpenXmlElement?.Source?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Source = (System.String?)value;
    }
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
    get => (String?)OpenXmlElement?.ImageSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageSize = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public Boolean? ImageAlignShape
  {
    get => (Boolean?)OpenXmlElement?.ImageAlignShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageAlignShape = (System.Boolean?)value;
    }
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
    get => (String?)OpenXmlElement?.Href?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Href = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public String? AlternateImageReference
  {
    get => (String?)OpenXmlElement?.AlternateImageReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlternateImageReference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public String? Title
  {
    get => (String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash
  {
    get => (Boolean?)OpenXmlElement?.ForceDash?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForceDash = (System.Boolean?)value;
    }
  }
  
}
