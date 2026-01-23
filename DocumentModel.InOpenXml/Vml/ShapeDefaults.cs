namespace DocumentModel.Vml;
/// <summary>
///   New Shape Defaults.
/// </summary>
public partial class ShapeDefaults : ModelElement<DXVO.ShapeDefaults>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Shape ID Optional Storage
    /// </summary>
    public Int64? MaxShapeId { get => _MaxShapeId; set => UpdateField(ref _MaxShapeId, value, nameof(MaxShapeId)); }

    private Int64? _MaxShapeId;
    /// <summary>
    ///   style
    /// </summary>
    public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

    private string? _Style;
    /// <summary>
    ///   Shape Fill Toggle
    /// </summary>
    public bool? BeFilled { get => _BeFilled; set => UpdateField(ref _BeFilled, value, nameof(BeFilled)); }

    private bool? _BeFilled;
    /// <summary>
    ///   Default Fill Color
    /// </summary>
    public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

    private string? _FillColor;
    /// <summary>
    ///   Shape Stroke Toggle
    /// </summary>
    public bool? IsStroke { get => _IsStroke; set => UpdateField(ref _IsStroke, value, nameof(IsStroke)); }

    private bool? _IsStroke;
    /// <summary>
    ///   Shape Stroke Color
    /// </summary>
    public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

    private string? _StrokeColor;
    /// <summary>
    ///   Allow in Table Cell
    /// </summary>
    public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

    private bool? _AllowInCell;
    /// <summary>
    ///   Allow shape overlap
    /// </summary>
    public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

    private bool? _AllowOverlap;
    /// <summary>
    ///   Type of Inset Margin
    /// </summary>
    public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

    private InsetMarginKind? _InsetMode;
    /// <summary>
    ///   Fill.
    /// </summary>
    public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

    private Fill? _Fill;
    /// <summary>
    ///   ImageData.
    /// </summary>
    public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

    private ImageData? _ImageData;
    /// <summary>
    ///   Stroke.
    /// </summary>
    public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

    private Stroke? _Stroke;
    /// <summary>
    ///   TextBox.
    /// </summary>
    public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

    private TextBox? _TextBox;
    /// <summary>
    ///   Shadow.
    /// </summary>
    public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

    private Shadow? _Shadow;
    /// <summary>
    ///   Skew.
    /// </summary>
    public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

    private Skew? _Skew;
    /// <summary>
    ///   Extrusion.
    /// </summary>
    public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

    private Extrusion? _Extrusion;
    /// <summary>
    ///   Callout.
    /// </summary>
    public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

    private Callout? _Callout;
    /// <summary>
    ///   Shape Protections.
    /// </summary>
    public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

    private Lock? _Lock;
    /// <summary>
    ///   Most Recently Used Colors.
    /// </summary>
    public ColorMostRecentlyUsed? ColorMostRecentlyUsed { get => _ColorMostRecentlyUsed; set => UpdateField(ref _ColorMostRecentlyUsed, value, nameof(ColorMostRecentlyUsed)); }

    private ColorMostRecentlyUsed? _ColorMostRecentlyUsed;
    /// <summary>
    ///   UI Default Colors.
    /// </summary>
    public ColorMenu? ColorMenu { get => _ColorMenu; set => UpdateField(ref _ColorMenu, value, nameof(ColorMenu)); }

    private ColorMenu? _ColorMenu;
}