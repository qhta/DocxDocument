namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reflection effect, including blur, opacity, position, distance, direction, scaling, skew, alignment, and rotation options.
/// </summary>
[OpenXmlType(typeof(DXD.Reflection))]
public partial class Reflection : ModelElement<DXD.Reflection>
{
    /// <summary>
    ///   Blur radius of the reflection.
    /// </summary>
    public Int64? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }

    private Int64? _BlurRadius;
    /// <summary>
    ///   Starting opacity of the reflection.
    /// </summary>
    public Int32? StartOpacity { get => _StartOpacity; set => UpdateField(ref _StartOpacity, value, nameof(StartOpacity)); }

    private Int32? _StartOpacity;
    /// <summary>
    ///   Starting position of the reflection.
    /// </summary>
    public Int32? StartPosition { get => _StartPosition; set => UpdateField(ref _StartPosition, value, nameof(StartPosition)); }

    private Int32? _StartPosition;
    /// <summary>
    ///   Ending alpha value of the reflection.
    /// </summary>
    public Int32? EndAlpha { get => _EndAlpha; set => UpdateField(ref _EndAlpha, value, nameof(EndAlpha)); }

    private Int32? _EndAlpha;
    /// <summary>
    ///   Ending position of the reflection.
    /// </summary>
    public Int32? EndPosition { get => _EndPosition; set => UpdateField(ref _EndPosition, value, nameof(EndPosition)); }

    private Int32? _EndPosition;
    /// <summary>
    ///   Distance to offset the reflection from the object.
    /// </summary>
    public Int64? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }

    private Int64? _Distance;
    /// <summary>
    ///   Direction angle of the reflection.
    /// </summary>
    public Int32? Direction { get => _Direction; set => UpdateField(ref _Direction, value, nameof(Direction)); }

    private Int32? _Direction;
    /// <summary>
    ///   Fade direction of the reflection.
    /// </summary>
    public Int32? FadeDirection { get => _FadeDirection; set => UpdateField(ref _FadeDirection, value, nameof(FadeDirection)); }

    private Int32? _FadeDirection;
    /// <summary>
    ///   Horizontal scaling factor for the reflection.
    /// </summary>
    public Int32? HorizontalRatio { get => _HorizontalRatio; set => UpdateField(ref _HorizontalRatio, value, nameof(HorizontalRatio)); }

    private Int32? _HorizontalRatio;
    /// <summary>
    ///   Vertical scaling factor for the reflection.
    /// </summary>
    public Int32? VerticalRatio { get => _VerticalRatio; set => UpdateField(ref _VerticalRatio, value, nameof(VerticalRatio)); }

    private Int32? _VerticalRatio;
    /// <summary>
    ///   Horizontal skew of the reflection.
    /// </summary>
    public Int32? HorizontalSkew { get => _HorizontalSkew; set => UpdateField(ref _HorizontalSkew, value, nameof(HorizontalSkew)); }

    private Int32? _HorizontalSkew;
    /// <summary>
    ///   Vertical skew of the reflection.
    /// </summary>
    public Int32? VerticalSkew { get => _VerticalSkew; set => UpdateField(ref _VerticalSkew, value, nameof(VerticalSkew)); }

    private Int32? _VerticalSkew;
    /// <summary>
    ///   Alignment of the reflection relative to the object.
    /// </summary>
    public RectangleAlignmentKind? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

    private RectangleAlignmentKind? _Alignment;
    /// <summary>
    ///   Indicates whether the reflection rotates with the shape.
    /// </summary>
    public bool? RotateWithShape { get => _RotateWithShape; set => UpdateField(ref _RotateWithShape, value, nameof(RotateWithShape)); }

    private bool? _RotateWithShape;
}