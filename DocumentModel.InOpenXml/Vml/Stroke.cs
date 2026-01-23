namespace DocumentModel.Vml;
/// <summary>
///   Defines the Stroke Class.
/// </summary>
public partial class Stroke : ModelElement<DXV.Stroke>
{
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Id))]
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Stroke Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.On))]
    /// <summary>
    ///   Stroke Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Stroke Weight
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Weight))]
    /// <summary>
    ///   Stroke Weight
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Weight { get => _Weight; set => UpdateField(ref _Weight, value, nameof(Weight)); }

    private string? _Weight;
    /// <summary>
    ///   Stroke Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Color))]
    /// <summary>
    ///   Stroke Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

    private string? _Color;
    /// <summary>
    ///   Stroke Opacity
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Opacity))]
    /// <summary>
    ///   Stroke Opacity
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Opacity { get => _Opacity; set => UpdateField(ref _Opacity, value, nameof(Opacity)); }

    private string? _Opacity;
    /// <summary>
    ///   Stroke Line Style
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.LineStyle))]
    /// <summary>
    ///   Stroke Line Style
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeLineStyleKind? LineStyle { get => _LineStyle; set => UpdateField(ref _LineStyle, value, nameof(LineStyle)); }

    private StrokeLineStyleKind? _LineStyle;
    /// <summary>
    ///   Miter Joint Limit
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Miterlimit))]
    /// <summary>
    ///   Miter Joint Limit
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? MiterLimit { get => _MiterLimit; set => UpdateField(ref _MiterLimit, value, nameof(MiterLimit)); }

    private string? _MiterLimit;
    /// <summary>
    ///   Line End Join Style
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.JoinStyle))]
    /// <summary>
    ///   Line End Join Style
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeJoinStyleKind? JoinStyle { get => _JoinStyle; set => UpdateField(ref _JoinStyle, value, nameof(JoinStyle)); }

    private StrokeJoinStyleKind? _JoinStyle;
    /// <summary>
    ///   Line End Cap
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.EndCap))]
    /// <summary>
    ///   Line End Cap
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeEndCapKind? EndCap { get => _EndCap; set => UpdateField(ref _EndCap, value, nameof(EndCap)); }

    private StrokeEndCapKind? _EndCap;
    /// <summary>
    ///   Stroke Dash Pattern
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.DashStyle))]
    /// <summary>
    ///   Stroke Dash Pattern
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? DashStyle { get => _DashStyle; set => UpdateField(ref _DashStyle, value, nameof(DashStyle)); }

    private string? _DashStyle;
    /// <summary>
    ///   Stroke Image Style
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.FillType))]
    /// <summary>
    ///   Stroke Image Style
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeFillKind? FillType { get => _FillType; set => UpdateField(ref _FillType, value, nameof(FillType)); }

    private StrokeFillKind? _FillType;
    /// <summary>
    ///   Stroke Image Location
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Source))]
    /// <summary>
    ///   Stroke Image Location
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Source { get => _Source; set => UpdateField(ref _Source, value, nameof(Source)); }

    private string? _Source;
    /// <summary>
    ///   Stroke Image Aspect Ratio
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.ImageAspect))]
    /// <summary>
    ///   Stroke Image Aspect Ratio
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public ImageAspectKind? ImageAspect { get => _ImageAspect; set => UpdateField(ref _ImageAspect, value, nameof(ImageAspect)); }

    private ImageAspectKind? _ImageAspect;
    /// <summary>
    ///   Stroke Image Size
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.ImageSize))]
    /// <summary>
    ///   Stroke Image Size
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? ImageSize { get => _ImageSize; set => UpdateField(ref _ImageSize, value, nameof(ImageSize)); }

    private string? _ImageSize;
    /// <summary>
    ///   Stoke Image Alignment
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.ImageAlignShape))]
    /// <summary>
    ///   Stoke Image Alignment
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public bool? ImageAlignShape { get => _ImageAlignShape; set => UpdateField(ref _ImageAlignShape, value, nameof(ImageAlignShape)); }

    private bool? _ImageAlignShape;
    /// <summary>
    ///   Stroke Alternate Pattern Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Color2))]
    /// <summary>
    ///   Stroke Alternate Pattern Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Color2 { get => _Color2; set => UpdateField(ref _Color2, value, nameof(Color2)); }

    private string? _Color2;
    /// <summary>
    ///   Line Start Arrowhead
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.StartArrow))]
    /// <summary>
    ///   Line Start Arrowhead
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeArrowKind? StartArrow { get => _StartArrow; set => UpdateField(ref _StartArrow, value, nameof(StartArrow)); }

    private StrokeArrowKind? _StartArrow;
    /// <summary>
    ///   Line Start Arrowhead Width
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.StartArrowWidth))]
    /// <summary>
    ///   Line Start Arrowhead Width
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeArrowWidthKind? StartArrowWidth { get => _StartArrowWidth; set => UpdateField(ref _StartArrowWidth, value, nameof(StartArrowWidth)); }

    private StrokeArrowWidthKind? _StartArrowWidth;
    /// <summary>
    ///   Line Start Arrowhead Length
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.StartArrowLength))]
    /// <summary>
    ///   Line Start Arrowhead Length
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeArrowLengthKind? StartArrowLength { get => _StartArrowLength; set => UpdateField(ref _StartArrowLength, value, nameof(StartArrowLength)); }

    private StrokeArrowLengthKind? _StartArrowLength;
    /// <summary>
    ///   Line End Arrowhead
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.EndArrow))]
    /// <summary>
    ///   Line End Arrowhead
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeArrowKind? EndArrow { get => _EndArrow; set => UpdateField(ref _EndArrow, value, nameof(EndArrow)); }

    private StrokeArrowKind? _EndArrow;
    /// <summary>
    ///   Line End Arrowhead Width
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.EndArrowWidth))]
    /// <summary>
    ///   Line End Arrowhead Width
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeArrowWidthKind? EndArrowWidth { get => _EndArrowWidth; set => UpdateField(ref _EndArrowWidth, value, nameof(EndArrowWidth)); }

    private StrokeArrowWidthKind? _EndArrowWidth;
    /// <summary>
    ///   Line End Arrowhead Length
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.EndArrowLength))]
    /// <summary>
    ///   Line End Arrowhead Length
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeArrowLengthKind? EndArrowLength { get => _EndArrowLength; set => UpdateField(ref _EndArrowLength, value, nameof(EndArrowLength)); }

    private StrokeArrowLengthKind? _EndArrowLength;
    /// <summary>
    ///   Original Image Reference
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Href))]
    /// <summary>
    ///   Original Image Reference
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

    private string? _Href;
    /// <summary>
    ///   Alternate Image Reference
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.AlternateImageReference))]
    /// <summary>
    ///   Alternate Image Reference
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? AlternateImageReference { get => _AlternateImageReference; set => UpdateField(ref _AlternateImageReference, value, nameof(AlternateImageReference)); }

    private string? _AlternateImageReference;
    /// <summary>
    ///   Stroke Title
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Title))]
    /// <summary>
    ///   Stroke Title
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

    private string? _Title;
    /// <summary>
    ///   Force Dashed Outline
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.ForceDash))]
    /// <summary>
    ///   Force Dashed Outline
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

    private bool? _ForceDash;
    /// <summary>
    ///   Relationship
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.RelationshipId))]
    /// <summary>
    ///   Relationship
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public string? RelationshipId { get => _RelationshipId; set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId)); }

    private string? _RelationshipId;
    /// <summary>
    ///   Inset Border From Path
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.Insetpen))]
    /// <summary>
    ///   Inset Border From Path
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public bool? Insetpen { get => _Insetpen; set => UpdateField(ref _Insetpen, value, nameof(Insetpen)); }

    private bool? _Insetpen;
    /// <summary>
    ///   LeftStroke.
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.LeftStroke))]
    /// <summary>
    ///   LeftStroke.
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeChildType? LeftStroke { get => _LeftStroke; set => UpdateField(ref _LeftStroke, value, nameof(LeftStroke)); }

    private StrokeChildType? _LeftStroke;
    /// <summary>
    ///   TopStroke.
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.TopStroke))]
    /// <summary>
    ///   TopStroke.
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeChildType? TopStroke { get => _TopStroke; set => UpdateField(ref _TopStroke, value, nameof(TopStroke)); }

    private StrokeChildType? _TopStroke;
    /// <summary>
    ///   RightStroke.
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.RightStroke))]
    /// <summary>
    ///   RightStroke.
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeChildType? RightStroke { get => _RightStroke; set => UpdateField(ref _RightStroke, value, nameof(RightStroke)); }

    private StrokeChildType? _RightStroke;
    /// <summary>
    ///   BottomStroke.
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.BottomStroke))]
    /// <summary>
    ///   BottomStroke.
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeChildType? BottomStroke { get => _BottomStroke; set => UpdateField(ref _BottomStroke, value, nameof(BottomStroke)); }

    private StrokeChildType? _BottomStroke;
    /// <summary>
    ///   ColumnStroke.
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Stroke.ColumnStroke))]
    /// <summary>
    ///   ColumnStroke.
    /// </summary>
    [OpenXmlElement(typeof(DXV.Stroke))]
    public StrokeChildType? ColumnStroke { get => _ColumnStroke; set => UpdateField(ref _ColumnStroke, value, nameof(ColumnStroke)); }

    private StrokeChildType? _ColumnStroke;
}