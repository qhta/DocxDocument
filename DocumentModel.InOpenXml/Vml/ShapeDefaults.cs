namespace DocumentModel.Vml;
/// <summary>
///   New Shape Defaults.
/// </summary>
public partial class ShapeDefaults : ModelElement<DXVO.ShapeDefaults>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Extension))]
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Shape ID Optional Storage
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.MaxShapeId))]
    /// <summary>
    ///   Shape ID Optional Storage
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Int64? MaxShapeId { get => _MaxShapeId; set => UpdateField(ref _MaxShapeId, value, nameof(MaxShapeId)); }

    private Int64? _MaxShapeId;
    /// <summary>
    ///   style
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Style))]
    /// <summary>
    ///   style
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

    private string? _Style;
    /// <summary>
    ///   Shape Fill Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.BeFilled))]
    /// <summary>
    ///   Shape Fill Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public bool? BeFilled { get => _BeFilled; set => UpdateField(ref _BeFilled, value, nameof(BeFilled)); }

    private bool? _BeFilled;
    /// <summary>
    ///   Default Fill Color
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.FillColor))]
    /// <summary>
    ///   Default Fill Color
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

    private string? _FillColor;
    /// <summary>
    ///   Shape Stroke Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.IsStroke))]
    /// <summary>
    ///   Shape Stroke Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public bool? IsStroke { get => _IsStroke; set => UpdateField(ref _IsStroke, value, nameof(IsStroke)); }

    private bool? _IsStroke;
    /// <summary>
    ///   Shape Stroke Color
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.StrokeColor))]
    /// <summary>
    ///   Shape Stroke Color
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

    private string? _StrokeColor;
    /// <summary>
    ///   Allow in Table Cell
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.AllowInCell))]
    /// <summary>
    ///   Allow in Table Cell
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

    private bool? _AllowInCell;
    /// <summary>
    ///   Allow shape overlap
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.AllowOverlap))]
    /// <summary>
    ///   Allow shape overlap
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

    private bool? _AllowOverlap;
    /// <summary>
    ///   Type of Inset Margin
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.InsetMode))]
    /// <summary>
    ///   Type of Inset Margin
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

    private InsetMarginKind? _InsetMode;
    /// <summary>
    ///   Fill.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Fill))]
    /// <summary>
    ///   Fill.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

    private Fill? _Fill;
    /// <summary>
    ///   ImageData.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.ImageData))]
    /// <summary>
    ///   ImageData.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

    private ImageData? _ImageData;
    /// <summary>
    ///   Stroke.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Stroke))]
    /// <summary>
    ///   Stroke.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

    private Stroke? _Stroke;
    /// <summary>
    ///   TextBox.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.TextBox))]
    /// <summary>
    ///   TextBox.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

    private TextBox? _TextBox;
    /// <summary>
    ///   Shadow.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Shadow))]
    /// <summary>
    ///   Shadow.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

    private Shadow? _Shadow;
    /// <summary>
    ///   Skew.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Skew))]
    /// <summary>
    ///   Skew.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

    private Skew? _Skew;
    /// <summary>
    ///   Extrusion.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Extrusion))]
    /// <summary>
    ///   Extrusion.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

    private Extrusion? _Extrusion;
    /// <summary>
    ///   Callout.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Callout))]
    /// <summary>
    ///   Callout.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

    private Callout? _Callout;
    /// <summary>
    ///   Shape Protections.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Lock))]
    /// <summary>
    ///   Shape Protections.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

    private Lock? _Lock;
    /// <summary>
    ///   Most Recently Used Colors.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.ColorMostRecentlyUsed))]
    /// <summary>
    ///   Most Recently Used Colors.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public ColorMostRecentlyUsed? ColorMostRecentlyUsed { get => _ColorMostRecentlyUsed; set => UpdateField(ref _ColorMostRecentlyUsed, value, nameof(ColorMostRecentlyUsed)); }

    private ColorMostRecentlyUsed? _ColorMostRecentlyUsed;
    /// <summary>
    ///   UI Default Colors.
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ShapeDefaults.ColorMenu))]
    /// <summary>
    ///   UI Default Colors.
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ShapeDefaults))]
    public ColorMenu? ColorMenu { get => _ColorMenu; set => UpdateField(ref _ColorMenu, value, nameof(ColorMenu)); }

    private ColorMenu? _ColorMenu;
}