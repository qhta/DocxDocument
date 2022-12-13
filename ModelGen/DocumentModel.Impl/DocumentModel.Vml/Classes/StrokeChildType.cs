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
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.On?.Value;
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
    get => (System.String?)OpenXmlElement?.Weight?.Value;
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
    get => (System.String?)OpenXmlElement?.Color?.Value;
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
    get => (System.String?)OpenXmlElement?.Color2?.Value;
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
    get => (System.String?)OpenXmlElement?.Opacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Opacity = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public DocumentModel.Vml.StrokeLineStyleKind? LineStyle
  {
    get => (DocumentModel.Vml.StrokeLineStyleKind?)OpenXmlElement?.LineStyle?.Value;
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
    get => (System.Decimal?)OpenXmlElement?.MiterLimit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MiterLimit = (System.Decimal?)value;
    }
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public DocumentModel.Vml.StrokeJoinStyleKind? JoinStyle
  {
    get => (DocumentModel.Vml.StrokeJoinStyleKind?)OpenXmlElement?.JoinStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.JoinStyle = (DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public DocumentModel.Vml.StrokeEndCapKind? EndCap
  {
    get => (DocumentModel.Vml.StrokeEndCapKind?)OpenXmlElement?.EndCap?.Value;
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
    get => (System.String?)OpenXmlElement?.DashStyle?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.InsetPen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetPen = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public DocumentModel.Vml.FillKind? FillType
  {
    get => (DocumentModel.Vml.FillKind?)OpenXmlElement?.FillType?.Value;
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
    get => (System.String?)OpenXmlElement?.Source?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Source = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public DocumentModel.Vml.ImageAspectKind? ImageAspect
  {
    get => (DocumentModel.Vml.ImageAspectKind?)OpenXmlElement?.ImageAspect?.Value;
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
    get => (System.String?)OpenXmlElement?.ImageSize?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.ImageAlignShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageAlignShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public DocumentModel.Vml.StrokeArrowKind? StartArrow
  {
    get => (DocumentModel.Vml.StrokeArrowKind?)OpenXmlElement?.StartArrow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartArrow = (DocumentFormat.OpenXml.Vml.StrokeArrowValues?)value;
    }
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public DocumentModel.Vml.StrokeArrowWidthKind? StartArrowWidth
  {
    get => (DocumentModel.Vml.StrokeArrowWidthKind?)OpenXmlElement?.StartArrowWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartArrowWidth = (DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues?)value;
    }
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public DocumentModel.Vml.StrokeArrowLengthKind? StartArrowLength
  {
    get => (DocumentModel.Vml.StrokeArrowLengthKind?)OpenXmlElement?.StartArrowLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartArrowLength = (DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public DocumentModel.Vml.StrokeArrowKind? EndArrow
  {
    get => (DocumentModel.Vml.StrokeArrowKind?)OpenXmlElement?.EndArrow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndArrow = (DocumentFormat.OpenXml.Vml.StrokeArrowValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public DocumentModel.Vml.StrokeArrowWidthKind? EndArrowWidth
  {
    get => (DocumentModel.Vml.StrokeArrowWidthKind?)OpenXmlElement?.EndArrowWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndArrowWidth = (DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues?)value;
    }
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public DocumentModel.Vml.StrokeArrowLengthKind? EndArrowLength
  {
    get => (DocumentModel.Vml.StrokeArrowLengthKind?)OpenXmlElement?.EndArrowLength?.Value;
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
    get => (System.String?)OpenXmlElement?.Href?.Value;
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
    get => (System.String?)OpenXmlElement?.AlternateImageReference?.Value;
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
    get => (System.String?)OpenXmlElement?.Title?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.ForceDash?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForceDash = (System.Boolean?)value;
    }
  }
  
}
