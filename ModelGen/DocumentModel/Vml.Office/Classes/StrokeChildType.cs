namespace DocumentModel.Vml.Office;


/// <summary>
///   Defines the StrokeChildType Class.
/// </summary>
public partial class StrokeChildType
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [SchemaAttr("on")]
  public Boolean? On { get; set; }
  
  
  /// <summary>
  ///   Stroke Weight
  /// </summary>
  [SchemaAttr("weight")]
  public String? Weight { get; set; }
  
  
  /// <summary>
  ///   Stroke Color
  /// </summary>
  [SchemaAttr("color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  [SchemaAttr("color2")]
  public String? Color2 { get; set; }
  
  
  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  [SchemaAttr("opacity")]
  public String? Opacity { get; set; }
  
  
  /// <summary>
  ///   Stroke Line Style
  /// </summary>
  [SchemaAttr("linestyle")]
  public DocumentModel.Vml.StrokeLineStyleValues? LineStyle { get; set; }
  
  
  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  [SchemaAttr("miterlimit")]
  public Decimal? MiterLimit { get; set; }
  
  
  /// <summary>
  ///   Line End Join Style)
  /// </summary>
  [SchemaAttr("joinstyle")]
  public DocumentModel.Vml.StrokeJoinStyleValues? JoinStyle { get; set; }
  
  
  /// <summary>
  ///   Line End Cap
  /// </summary>
  [SchemaAttr("endcap")]
  public DocumentModel.Vml.StrokeEndCapValues? EndCap { get; set; }
  
  
  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  [SchemaAttr("dashstyle")]
  public String? DashStyle { get; set; }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [SchemaAttr("insetpen")]
  public Boolean? InsetPen { get; set; }
  
  
  /// <summary>
  ///   Stroke Image Style
  /// </summary>
  [SchemaAttr("filltype")]
  public DocumentModel.Vml.FillTypeValues? FillType { get; set; }
  
  
  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  [SchemaAttr("src")]
  public String? Source { get; set; }
  
  
  /// <summary>
  ///   Stroke Image Aspect Ratio
  /// </summary>
  [SchemaAttr("imageaspect")]
  public DocumentModel.Vml.ImageAspectValues? ImageAspect { get; set; }
  
  
  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  [SchemaAttr("imagesize")]
  public String? ImageSize { get; set; }
  
  
  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  [SchemaAttr("imagealignshape")]
  public Boolean? ImageAlignShape { get; set; }
  
  
  /// <summary>
  ///   Line Start Arrowhead
  /// </summary>
  [SchemaAttr("startarrow")]
  public DocumentModel.Vml.StrokeArrowValues? StartArrow { get; set; }
  
  
  /// <summary>
  ///   Line Start Arrowhead Width
  /// </summary>
  [SchemaAttr("startarrowwidth")]
  public DocumentModel.Vml.StrokeArrowWidthValues? StartArrowWidth { get; set; }
  
  
  /// <summary>
  ///   Line Start Arrowhead Length
  /// </summary>
  [SchemaAttr("startarrowlength")]
  public DocumentModel.Vml.StrokeArrowLengthValues? StartArrowLength { get; set; }
  
  
  /// <summary>
  ///   Line End Arrowhead
  /// </summary>
  [SchemaAttr("endarrow")]
  public DocumentModel.Vml.StrokeArrowValues? EndArrow { get; set; }
  
  
  /// <summary>
  ///   Line End Arrowhead Width
  /// </summary>
  [SchemaAttr("endarrowwidth")]
  public DocumentModel.Vml.StrokeArrowWidthValues? EndArrowWidth { get; set; }
  
  
  /// <summary>
  ///   Line End Arrowhead Length
  /// </summary>
  [SchemaAttr("endarrowlength")]
  public DocumentModel.Vml.StrokeArrowLengthValues? EndArrowLength { get; set; }
  
  
  /// <summary>
  ///   Original Image Reference
  /// </summary>
  [SchemaAttr("o:href")]
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  [SchemaAttr("o:althref")]
  public String? AlternateImageReference { get; set; }
  
  
  /// <summary>
  ///   Stroke Title
  /// </summary>
  [SchemaAttr("o:title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [SchemaAttr("o:forcedash")]
  public Boolean? ForceDash { get; set; }
  
}
