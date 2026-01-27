namespace DocumentModel.Vml;
/// <summary>
///   Defines the StrokeChildType Class.
/// </summary>
[OpenXmlType(typeof(DXVO.StrokeChildType))]
public partial class StrokeChildType : ModelElement<DXVO.StrokeChildType>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Extension))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Stroke Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.On))]
 public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

 private bool? _On;
 /// <summary>
 ///   Stroke Weight
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Weight))]
 public string? Weight { get => _Weight; set => UpdateField(ref _Weight, value, nameof(Weight)); }

 private string? _Weight;
 /// <summary>
 ///   Stroke Color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Color))]
 public string? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

 private string? _Color;
 /// <summary>
 ///   Stroke Alternate Pattern Color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Color2))]
 public string? Color2 { get => _Color2; set => UpdateField(ref _Color2, value, nameof(Color2)); }

 private string? _Color2;
 /// <summary>
 ///   Stroke Opacity
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Opacity))]
 public string? Opacity { get => _Opacity; set => UpdateField(ref _Opacity, value, nameof(Opacity)); }

 private string? _Opacity;
 /// <summary>
 ///   Stroke Line Style
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.LineStyle))]
 public StrokeLineStyleKind? LineStyle { get => _LineStyle; set => UpdateField(ref _LineStyle, value, nameof(LineStyle)); }

 private StrokeLineStyleKind? _LineStyle;
 /// <summary>
 ///   Miter Joint Limit
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.MiterLimit))]
 public Decimal? MiterLimit { get => _MiterLimit; set => UpdateField(ref _MiterLimit, value, nameof(MiterLimit)); }

 private Decimal? _MiterLimit;
 /// <summary>
 ///   Line End Join Style)
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.JoinStyle))]
 public StrokeJoinStyleKind? JoinStyle { get => _JoinStyle; set => UpdateField(ref _JoinStyle, value, nameof(JoinStyle)); }

 private StrokeJoinStyleKind? _JoinStyle;
 /// <summary>
 ///   Line End Cap
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.EndCap))]
 public StrokeEndCapKind? EndCap { get => _EndCap; set => UpdateField(ref _EndCap, value, nameof(EndCap)); }

 private StrokeEndCapKind? _EndCap;
 /// <summary>
 ///   Stroke Dash Pattern
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.DashStyle))]
 public string? DashStyle { get => _DashStyle; set => UpdateField(ref _DashStyle, value, nameof(DashStyle)); }

 private string? _DashStyle;
 /// <summary>
 ///   Inset Border From Path
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.InsetPen))]
 public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }

 private bool? _InsetPen;
 /// <summary>
 ///   Stroke Image Style
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.FillType))]
 public FillTypeKind? FillType { get => _FillType; set => UpdateField(ref _FillType, value, nameof(FillType)); }

 private FillTypeKind? _FillType;
 /// <summary>
 ///   Stroke Image Location
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Source))]
 public string? Source { get => _Source; set => UpdateField(ref _Source, value, nameof(Source)); }

 private string? _Source;
 /// <summary>
 ///   Stroke Image Aspect Ratio
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.ImageAspect))]
 public ImageAspectKind? ImageAspect { get => _ImageAspect; set => UpdateField(ref _ImageAspect, value, nameof(ImageAspect)); }

 private ImageAspectKind? _ImageAspect;
 /// <summary>
 ///   Stroke Image Size
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.ImageSize))]
 public string? ImageSize { get => _ImageSize; set => UpdateField(ref _ImageSize, value, nameof(ImageSize)); }

 private string? _ImageSize;
 /// <summary>
 ///   Stoke Image Alignment
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.ImageAlignShape))]
 public bool? ImageAlignShape { get => _ImageAlignShape; set => UpdateField(ref _ImageAlignShape, value, nameof(ImageAlignShape)); }

 private bool? _ImageAlignShape;
 /// <summary>
 ///   Line Start Arrowhead
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.StartArrow))]
 public StrokeArrowKind? StartArrow { get => _StartArrow; set => UpdateField(ref _StartArrow, value, nameof(StartArrow)); }

 private StrokeArrowKind? _StartArrow;
 /// <summary>
 ///   Line Start Arrowhead Width
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.StartArrowWidth))]
 public StrokeArrowWidthKind? StartArrowWidth { get => _StartArrowWidth; set => UpdateField(ref _StartArrowWidth, value, nameof(StartArrowWidth)); }

 private StrokeArrowWidthKind? _StartArrowWidth;
 /// <summary>
 ///   Line Start Arrowhead Length
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.StartArrowLength))]
 public StrokeArrowLengthKind? StartArrowLength { get => _StartArrowLength; set => UpdateField(ref _StartArrowLength, value, nameof(StartArrowLength)); }

 private StrokeArrowLengthKind? _StartArrowLength;
 /// <summary>
 ///   Line End Arrowhead
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.EndArrow))]
 public StrokeArrowKind? EndArrow { get => _EndArrow; set => UpdateField(ref _EndArrow, value, nameof(EndArrow)); }

 private StrokeArrowKind? _EndArrow;
 /// <summary>
 ///   Line End Arrowhead Width
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.EndArrowWidth))]
 public StrokeArrowWidthKind? EndArrowWidth { get => _EndArrowWidth; set => UpdateField(ref _EndArrowWidth, value, nameof(EndArrowWidth)); }

 private StrokeArrowWidthKind? _EndArrowWidth;
 /// <summary>
 ///   Line End Arrowhead Length
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.EndArrowLength))]
 public StrokeArrowLengthKind? EndArrowLength { get => _EndArrowLength; set => UpdateField(ref _EndArrowLength, value, nameof(EndArrowLength)); }

 private StrokeArrowLengthKind? _EndArrowLength;
 /// <summary>
 ///   Original Image Reference
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Href))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

 private string? _Href;
 /// <summary>
 ///   Alternate Image Reference
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.AlternateImageReference))]
 public string? AlternateImageReference { get => _AlternateImageReference; set => UpdateField(ref _AlternateImageReference, value, nameof(AlternateImageReference)); }

 private string? _AlternateImageReference;
 /// <summary>
 ///   Stroke Title
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.Title))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   Force Dashed Outline
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.StrokeChildType.ForceDash))]
 public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

 private bool? _ForceDash;
}