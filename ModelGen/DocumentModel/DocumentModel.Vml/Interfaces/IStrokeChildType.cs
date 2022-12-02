namespace DocumentModel.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public interface IStrokeChildType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public System.String? Weight { get ; set; }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public System.String? Color2 { get ; set; }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public System.String? Opacity { get ; set; }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public DocumentModel.Vml.StrokeLineStyleKind? LineStyle { get ; set; }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public System.Decimal? MiterLimit { get ; set; }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public DocumentModel.Vml.StrokeJoinStyleKind? JoinStyle { get ; set; }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public DocumentModel.Vml.StrokeEndCapKind? EndCap { get ; set; }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public System.String? DashStyle { get ; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public System.Boolean? InsetPen { get ; set; }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public DocumentModel.Vml.FillKind? FillType { get ; set; }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public System.String? Source { get ; set; }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public DocumentModel.Vml.ImageAspectKind? ImageAspect { get ; set; }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public System.String? ImageSize { get ; set; }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public System.Boolean? ImageAlignShape { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public DocumentModel.Vml.StrokeArrowKind? StartArrow { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public DocumentModel.Vml.StrokeArrowWidthKind? StartArrowWidth { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public DocumentModel.Vml.StrokeArrowLengthKind? StartArrowLength { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public DocumentModel.Vml.StrokeArrowKind? EndArrow { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public DocumentModel.Vml.StrokeArrowWidthKind? EndArrowWidth { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public DocumentModel.Vml.StrokeArrowLengthKind? EndArrowLength { get ; set; }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public System.String? Href { get ; set; }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public System.String? AlternateImageReference { get ; set; }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public System.Boolean? ForceDash { get ; set; }
  
}
