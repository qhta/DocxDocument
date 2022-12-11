namespace DocumentModel.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public class StrokeImpl: ModelElementImpl, Stroke
{
  public DocumentFormat.OpenXml.Vml.Stroke? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Stroke?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrokeImpl(): base() {}
  
  public StrokeImpl(DocumentFormat.OpenXml.Vml.Stroke openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
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
  public String? Miterlimit
  {
    get => (String?)OpenXmlElement?.Miterlimit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Miterlimit = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Line End Join Style
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
  /// Stroke Image Style
  /// </summary>
  public StrokeFillKind? FillType
  {
    get => (StrokeFillKind?)OpenXmlElement?.FillType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FillType = (DocumentFormat.OpenXml.Vml.StrokeFillTypeValues?)value;
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
  
  /// <summary>
  /// Relationship
  /// </summary>
  public String? RelationshipId
  {
    get => (String?)OpenXmlElement?.RelationshipId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelationshipId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? Insetpen
  {
    get => (Boolean?)OpenXmlElement?.Insetpen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Insetpen = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  public StrokeChildType? LeftStroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  public StrokeChildType? TopStroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  public StrokeChildType? RightStroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  public StrokeChildType? BottomStroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  public StrokeChildType? ColumnStroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
