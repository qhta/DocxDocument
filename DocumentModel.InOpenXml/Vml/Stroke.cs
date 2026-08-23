namespace DocumentModel.Vml;

/// <summary>
///   Defines the Stroke Class.
/// </summary>
[OpenXmlType(typeof(DXV.Stroke))]
[DataContract]
[XmlRoot("Stroke", Namespace = "DocumentModel.Vml")]
public partial class Stroke: ModelElement<DXV.Stroke>
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.On))]
  public bool? On
  {
    get => _On ??= GetProperty<bool?>(GetUpdatableElement()?.On);
    set => UpdateField(ref _On, value, nameof(On));
  }

  private bool? _On;

  /// <summary>
  ///   Stroke Weight
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Weight))]
  public string? Weight
  {
    get => _Weight ??= GetProperty<string?>(GetUpdatableElement()?.Weight);
    set => UpdateField(ref _Weight, value, nameof(Weight));
  }

  private string? _Weight;

  /// <summary>
  ///   Stroke Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Color))]
  public VmlColor? Color
  {
    get => _Color ??= GetProperty<VmlColor?>(GetUpdatableElement()?.Color);
    set => UpdateField(ref _Color, value, nameof(Color));
  }

  private VmlColor? _Color;

  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Opacity))]
  public string? Opacity
  {
    get => _Opacity ??= GetProperty<string?>(GetUpdatableElement()?.Opacity);
    set => UpdateField(ref _Opacity, value, nameof(Opacity));
  }

  private string? _Opacity;

  /// <summary>
  ///   Stroke Line Style
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.LineStyle))]
  public StrokeLineStyle? LineStyle
  {
    get => _LineStyle ??= GetProperty<StrokeLineStyle?>(GetUpdatableElement()?.LineStyle);
    set => UpdateField(ref _LineStyle, value, nameof(LineStyle));
  }

  private StrokeLineStyle? _LineStyle;

  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Miterlimit))]
  public string? MiterLimit
  {
    get => _MiterLimit ??= GetProperty<string?>(GetUpdatableElement()?.Miterlimit);
    set => UpdateField(ref _MiterLimit, value, nameof(MiterLimit));
  }

  private string? _MiterLimit;

  /// <summary>
  ///   Line End Join Style
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.JoinStyle))]
  public StrokeJoinStyle? JoinStyle
  {
    get => _JoinStyle ??= GetProperty<StrokeJoinStyle?>(GetUpdatableElement()?.JoinStyle);
    set => UpdateField(ref _JoinStyle, value, nameof(JoinStyle));
  }

  private StrokeJoinStyle? _JoinStyle;

  /// <summary>
  ///   Line End Cap
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.EndCap))]
  public StrokeEndCap? EndCap
  {
    get => _EndCap ??= GetProperty<StrokeEndCap?>(GetUpdatableElement()?.EndCap);
    set => UpdateField(ref _EndCap, value, nameof(EndCap));
  }

  private StrokeEndCap? _EndCap;

  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.DashStyle))]
  public string? DashStyle
  {
    get => _DashStyle ??= GetProperty<string?>(GetUpdatableElement()?.DashStyle);
    set => UpdateField(ref _DashStyle, value, nameof(DashStyle));
  }

  private string? _DashStyle;

  /// <summary>
  ///   Stroke Image Style
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.FillType))]
  public StrokeFill? FillType
  {
    get => _FillType ??= GetProperty<StrokeFill?>(GetUpdatableElement()?.FillType);
    set => UpdateField(ref _FillType, value, nameof(FillType));
  }

  private StrokeFill? _FillType;

  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Source))]
  public string? Source
  {
    get => _Source ??= GetProperty<string?>(GetUpdatableElement()?.Source);
    set => UpdateField(ref _Source, value, nameof(Source));
  }

  private string? _Source;

  /// <summary>
  ///   Stroke Image Aspect Ratio
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.ImageAspect))]
  public ImageAspectType? ImageAspect
  {
    get => _ImageAspect ??= GetProperty<ImageAspectType?>(GetUpdatableElement()?.ImageAspect);
    set => UpdateField(ref _ImageAspect, value, nameof(ImageAspect));
  }

  private ImageAspectType? _ImageAspect;

  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.ImageSize))]
  public string? ImageSize
  {
    get => _ImageSize ??= GetProperty<string?>(GetUpdatableElement()?.ImageSize);
    set => UpdateField(ref _ImageSize, value, nameof(ImageSize));
  }

  private string? _ImageSize;

  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.ImageAlignShape))]
  public bool? ImageAlignShape
  {
    get => _ImageAlignShape ??= GetProperty<bool?>(GetUpdatableElement()?.ImageAlignShape);
    set => UpdateField(ref _ImageAlignShape, value, nameof(ImageAlignShape));
  }

  private bool? _ImageAlignShape;

  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Color2))]
  public VmlColor? Color2
  {
    get => _Color2 ??= GetProperty<VmlColor?>(GetUpdatableElement()?.Color2);
    set => UpdateField(ref _Color2, value, nameof(Color2));
  }

  private VmlColor? _Color2;

  /// <summary>
  ///   Line Start Arrowhead
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.StartArrow))]
  public StrokeArrowStyle? StartArrow
  {
    get => _StartArrow ??= GetProperty<StrokeArrowStyle?>(GetUpdatableElement()?.StartArrow);
    set => UpdateField(ref _StartArrow, value, nameof(StartArrow));
  }

  private StrokeArrowStyle? _StartArrow;

  /// <summary>
  ///   Line Start Arrowhead Width
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.StartArrowWidth))]
  public StrokeArrowWidth? StartArrowWidth
  {
    get => _StartArrowWidth ??= GetProperty<StrokeArrowWidth?>(GetUpdatableElement()?.StartArrowWidth);
    set => UpdateField(ref _StartArrowWidth, value, nameof(StartArrowWidth));
  }

  private StrokeArrowWidth? _StartArrowWidth;

  /// <summary>
  ///   Line Start Arrowhead Length
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.StartArrowLength))]
  public StrokeArrowLength? StartArrowLength
  {
    get => _StartArrowLength ??= GetProperty<StrokeArrowLength?>(GetUpdatableElement()?.StartArrowLength);
    set => UpdateField(ref _StartArrowLength, value, nameof(StartArrowLength));
  }

  private StrokeArrowLength? _StartArrowLength;

  /// <summary>
  ///   Line End Arrowhead
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.EndArrow))]
  public StrokeArrowStyle? EndArrow
  {
    get => _EndArrow ??= GetProperty<StrokeArrowStyle?>(GetUpdatableElement()?.EndArrow);
    set => UpdateField(ref _EndArrow, value, nameof(EndArrow));
  }

  private StrokeArrowStyle? _EndArrow;

  /// <summary>
  ///   Line End Arrowhead Width
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.EndArrowWidth))]
  public StrokeArrowWidth? EndArrowWidth
  {
    get => _EndArrowWidth ??= GetProperty<StrokeArrowWidth?>(GetUpdatableElement()?.EndArrowWidth);
    set => UpdateField(ref _EndArrowWidth, value, nameof(EndArrowWidth));
  }

  private StrokeArrowWidth? _EndArrowWidth;

  /// <summary>
  ///   Line End Arrowhead Length
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.EndArrowLength))]
  public StrokeArrowLength? EndArrowLength
  {
    get => _EndArrowLength ??= GetProperty<StrokeArrowLength?>(GetUpdatableElement()?.EndArrowLength);
    set => UpdateField(ref _EndArrowLength, value, nameof(EndArrowLength));
  }

  private StrokeArrowLength? _EndArrowLength;

  /// <summary>
  ///   Original Image Reference
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Href))]
  public string? Href
  {
    get => _Href ??= GetProperty<string?>(GetUpdatableElement()?.Href);
    set => UpdateField(ref _Href, value, nameof(Href));
  }

  private string? _Href;

  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.AlternateImageReference))]
  public string? AlternateImageReference
  {
    get => _AlternateImageReference ??= GetProperty<string?>(GetUpdatableElement()?.AlternateImageReference);
    set => UpdateField(ref _AlternateImageReference, value, nameof(AlternateImageReference));
  }

  private string? _AlternateImageReference;

  /// <summary>
  ///   Stroke Title
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Title))]
  public string? Title
  {
    get => _Title ??= GetProperty<string?>(GetUpdatableElement()?.Title);
    set => UpdateField(ref _Title, value, nameof(Title));
  }

  private string? _Title;

  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.ForceDash))]
  public bool? ForceDash
  {
    get => _ForceDash ??= GetProperty<bool?>(GetUpdatableElement()?.ForceDash);
    set => UpdateField(ref _ForceDash, value, nameof(ForceDash));
  }

  private bool? _ForceDash;

  /// <summary>
  ///   Relationship
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.RelationshipId))]
  public string? RelationshipId
  {
    get => _RelationshipId ??= GetProperty<string?>(GetUpdatableElement()?.RelationshipId);
    set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId));
  }

  private string? _RelationshipId;

  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.Insetpen))]
  public bool? Insetpen
  {
    get => _Insetpen ??= GetProperty<bool?>(GetUpdatableElement()?.Insetpen);
    set => UpdateField(ref _Insetpen, value, nameof(Insetpen));
  }

  private bool? _Insetpen;

  /// <summary>
  ///   LeftStroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.LeftStroke))]
  public StrokeChildType? LeftStroke
  {
    get => _LeftStroke ??= GetProperty<StrokeChildType?>(GetUpdatableElement()?.LeftStroke);
    set => UpdateField(ref _LeftStroke, value, nameof(LeftStroke));
  }

  private StrokeChildType? _LeftStroke;

  /// <summary>
  ///   TopStroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.TopStroke))]
  public StrokeChildType? TopStroke
  {
    get => _TopStroke ??= GetProperty<StrokeChildType?>(GetUpdatableElement()?.TopStroke);
    set => UpdateField(ref _TopStroke, value, nameof(TopStroke));
  }

  private StrokeChildType? _TopStroke;

  /// <summary>
  ///   RightStroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.RightStroke))]
  public StrokeChildType? RightStroke
  {
    get => _RightStroke ??= GetProperty<StrokeChildType?>(GetUpdatableElement()?.RightStroke);
    set => UpdateField(ref _RightStroke, value, nameof(RightStroke));
  }

  private StrokeChildType? _RightStroke;

  /// <summary>
  ///   BottomStroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.BottomStroke))]
  public StrokeChildType? BottomStroke
  {
    get => _BottomStroke ??= GetProperty<StrokeChildType?>(GetUpdatableElement()?.BottomStroke);
    set => UpdateField(ref _BottomStroke, value, nameof(BottomStroke));
  }

  private StrokeChildType? _BottomStroke;

  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Stroke.ColumnStroke))]
  public StrokeChildType? ColumnStroke
  {
    get => _ColumnStroke ??= GetProperty<StrokeChildType?>(GetUpdatableElement()?.ColumnStroke);
    set => UpdateField(ref _ColumnStroke, value, nameof(ColumnStroke));
  }

  private StrokeChildType? _ColumnStroke;
}