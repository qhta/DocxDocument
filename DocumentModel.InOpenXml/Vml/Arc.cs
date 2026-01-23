using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
///   Arc Segment.
/// </summary>
public partial class Arc : ModelElement<DXV.Arc>, IEmbeddedObjectContent
{
    /// <summary>
    ///   Optional String
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.OptionalString))]
    /// <summary>
    ///   Optional String
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }

    private string? _OptionalString;
    /// <summary>
    ///   Shape Handle Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Oned))]
    /// <summary>
    ///   Shape Handle Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }

    private bool? _Oned;
    /// <summary>
    ///   Regroup ID
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.RegroupId))]
    /// <summary>
    ///   Regroup ID
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }

    private Int64? _RegroupId;
    /// <summary>
    ///   Double-click Notification Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.DoubleClickNotify))]
    /// <summary>
    ///   Double-click Notification Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }

    private bool? _DoubleClickNotify;
    /// <summary>
    ///   Button Behavior Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Button))]
    /// <summary>
    ///   Button Behavior Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }

    private bool? _Button;
    /// <summary>
    ///   Hide Script Anchors
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.UserHidden))]
    /// <summary>
    ///   Hide Script Anchors
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }

    private bool? _UserHidden;
    /// <summary>
    ///   Graphical Bullet
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Bullet))]
    /// <summary>
    ///   Graphical Bullet
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }

    private bool? _Bullet;
    /// <summary>
    ///   Horizontal Rule Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Horizontal))]
    /// <summary>
    ///   Horizontal Rule Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }

    private bool? _Horizontal;
    /// <summary>
    ///   Horizontal Rule Standard Display Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.HorizontalStandard))]
    /// <summary>
    ///   Horizontal Rule Standard Display Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }

    private bool? _HorizontalStandard;
    /// <summary>
    ///   Horizontal Rule 3D Shading Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.HorizontalNoShade))]
    /// <summary>
    ///   Horizontal Rule 3D Shading Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }

    private bool? _HorizontalNoShade;
    /// <summary>
    ///   Horizontal Rule Length Percentage
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.HorizontalPercentage))]
    /// <summary>
    ///   Horizontal Rule Length Percentage
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }

    private Single? _HorizontalPercentage;
    /// <summary>
    ///   Horizontal Rule Alignment
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.HorizontalAlignment))]
    /// <summary>
    ///   Horizontal Rule Alignment
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public HorizontalRuleAlignmentKind? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }

    private HorizontalRuleAlignmentKind? _HorizontalAlignment;
    /// <summary>
    ///   Allow in Table Cell
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.AllowInCell))]
    /// <summary>
    ///   Allow in Table Cell
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

    private bool? _AllowInCell;
    /// <summary>
    ///   Allow Shape Overlap
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.AllowOverlap))]
    /// <summary>
    ///   Allow Shape Overlap
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

    private bool? _AllowOverlap;
    /// <summary>
    ///   Exists In Master Slide
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.UserDrawn))]
    /// <summary>
    ///   Exists In Master Slide
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }

    private bool? _UserDrawn;
    /// <summary>
    ///   Border Top Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.BorderTopColor))]
    /// <summary>
    ///   Border Top Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? BorderTopColor { get => _BorderTopColor; set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor)); }

    private string? _BorderTopColor;
    /// <summary>
    ///   Border Left Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.BorderLeftColor))]
    /// <summary>
    ///   Border Left Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? BorderLeftColor { get => _BorderLeftColor; set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor)); }

    private string? _BorderLeftColor;
    /// <summary>
    ///   Bottom Border Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.BorderBottomColor))]
    /// <summary>
    ///   Bottom Border Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? BorderBottomColor { get => _BorderBottomColor; set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor)); }

    private string? _BorderBottomColor;
    /// <summary>
    ///   Border Right Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.BorderRightColor))]
    /// <summary>
    ///   Border Right Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? BorderRightColor { get => _BorderRightColor; set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor)); }

    private string? _BorderRightColor;
    /// <summary>
    ///   Diagram Node Layout Identifier
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.DiagramLayout))]
    /// <summary>
    ///   Diagram Node Layout Identifier
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }

    private Int64? _DiagramLayout;
    /// <summary>
    ///   Diagram Node Identifier
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.DiagramNodeKind))]
    /// <summary>
    ///   Diagram Node Identifier
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }

    private Int64? _DiagramNodeKind;
    /// <summary>
    ///   Diagram Node Recent Layout Identifier
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.DiagramLayoutMostRecentUsed))]
    /// <summary>
    ///   Diagram Node Recent Layout Identifier
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }

    private Int64? _DiagramLayoutMostRecentUsed;
    /// <summary>
    ///   Text Inset Mode
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.InsetMode))]
    /// <summary>
    ///   Text Inset Mode
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

    private InsetMarginKind? _InsetMode;
    /// <summary>
    ///   Shape Fill Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Filled))]
    /// <summary>
    ///   Shape Fill Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }

    private bool? _Filled;
    /// <summary>
    ///   Fill Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.FillColor))]
    /// <summary>
    ///   Fill Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

    private string? _FillColor;
    /// <summary>
    ///   Shape Stroke Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Stroked))]
    /// <summary>
    ///   Shape Stroke Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Stroked { get => _Stroked; set => UpdateField(ref _Stroked, value, nameof(Stroked)); }

    private bool? _Stroked;
    /// <summary>
    ///   Shape Stroke Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.StrokeColor))]
    /// <summary>
    ///   Shape Stroke Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

    private string? _StrokeColor;
    /// <summary>
    ///   Shape Stroke Weight
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.StrokeWeight))]
    /// <summary>
    ///   Shape Stroke Weight
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? StrokeWeight { get => _StrokeWeight; set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight)); }

    private string? _StrokeWeight;
    /// <summary>
    ///   Inset Border From Path
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.InsetPen))]
    /// <summary>
    ///   Inset Border From Path
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }

    private bool? _InsetPen;
    /// <summary>
    ///   Optional Number
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.OptionalNumber))]
    /// <summary>
    ///   Optional Number
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Int32? OptionalNumber { get => _OptionalNumber; set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber)); }

    private Int32? _OptionalNumber;
    /// <summary>
    ///   Shape Connector Type
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.ConnectorType))]
    /// <summary>
    ///   Shape Connector Type
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public ConnectorKind? ConnectorType { get => _ConnectorType; set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType)); }

    private ConnectorKind? _ConnectorType;
    /// <summary>
    ///   Black-and-White Mode
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.BlackWhiteMode))]
    /// <summary>
    ///   Black-and-White Mode
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

    private BlackAndWhiteMode? _BlackWhiteMode;
    /// <summary>
    ///   Pure Black-and-White Mode
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.PureBlackWhiteMode))]
    /// <summary>
    ///   Pure Black-and-White Mode
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }

    private BlackAndWhiteMode? _PureBlackWhiteMode;
    /// <summary>
    ///   Normal Black-and-White Mode
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.NormalBlackWhiteMode))]
    /// <summary>
    ///   Normal Black-and-White Mode
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }

    private BlackAndWhiteMode? _NormalBlackWhiteMode;
    /// <summary>
    ///   Force Dashed Outline
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.ForceDash))]
    /// <summary>
    ///   Force Dashed Outline
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

    private bool? _ForceDash;
    /// <summary>
    ///   Embedded Object Icon Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.OleIcon))]
    /// <summary>
    ///   Embedded Object Icon Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? OleIcon { get => _OleIcon; set => UpdateField(ref _OleIcon, value, nameof(OleIcon)); }

    private bool? _OleIcon;
    /// <summary>
    ///   Embedded Object Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Ole))]
    /// <summary>
    ///   Embedded Object Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Ole { get => _Ole; set => UpdateField(ref _Ole, value, nameof(Ole)); }

    private bool? _Ole;
    /// <summary>
    ///   Relative Resize Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.PreferRelative))]
    /// <summary>
    ///   Relative Resize Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? PreferRelative { get => _PreferRelative; set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative)); }

    private bool? _PreferRelative;
    /// <summary>
    ///   Clip to Wrapping Polygon
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.ClipToWrap))]
    /// <summary>
    ///   Clip to Wrapping Polygon
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? ClipToWrap { get => _ClipToWrap; set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap)); }

    private bool? _ClipToWrap;
    /// <summary>
    ///   Clipping Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Clip))]
    /// <summary>
    ///   Clipping Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Clip { get => _Clip; set => UpdateField(ref _Clip, value, nameof(Clip)); }

    private bool? _Clip;
    /// <summary>
    ///   Encoded Package
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Gfxdata))]
    /// <summary>
    ///   Encoded Package
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Base64Binary? Gfxdata { get => _Gfxdata; set => UpdateField(ref _Gfxdata, value, nameof(Gfxdata)); }

    private Base64Binary? _Gfxdata;
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Id))]
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Shape Styling Properties
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Style))]
    /// <summary>
    ///   Shape Styling Properties
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

    private string? _Style;
    /// <summary>
    ///   IHyperlink Target
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Href))]
    /// <summary>
    ///   IHyperlink Target
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

    private string? _Href;
    /// <summary>
    ///   IHyperlink Display Target
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Target))]
    /// <summary>
    ///   IHyperlink Display Target
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }

    private string? _Target;
    /// <summary>
    ///   Shape Title
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Title))]
    /// <summary>
    ///   Shape Title
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

    private string? _Title;
    /// <summary>
    ///   Alternate Text
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Alternate))]
    /// <summary>
    ///   Alternate Text
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }

    private string? _Alternate;
    /// <summary>
    ///   Coordinate Space Size
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.CoordinateSize))]
    /// <summary>
    ///   Coordinate Space Size
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }

    private string? _CoordinateSize;
    /// <summary>
    ///   Coordinate Space Origin
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.CoordinateOrigin))]
    /// <summary>
    ///   Coordinate Space Origin
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? CoordinateOrigin { get => _CoordinateOrigin; set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin)); }

    private string? _CoordinateOrigin;
    /// <summary>
    ///   Shape Bounding Polygon
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Wrapcoords))]
    /// <summary>
    ///   Shape Bounding Polygon
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public string? Wrapcoords { get => _Wrapcoords; set => UpdateField(ref _Wrapcoords, value, nameof(Wrapcoords)); }

    private string? _Wrapcoords;
    /// <summary>
    ///   Print Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.Print))]
    /// <summary>
    ///   Print Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }

    private bool? _Print;
    /// <summary>
    ///   Starting Angle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.StartAngle))]
    /// <summary>
    ///   Starting Angle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Decimal? StartAngle { get => _StartAngle; set => UpdateField(ref _StartAngle, value, nameof(StartAngle)); }

    private Decimal? _StartAngle;
    /// <summary>
    ///   Ending Angle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Arc.EndAngle))]
    /// <summary>
    ///   Ending Angle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Arc))]
    public Decimal? EndAngle { get => _EndAngle; set => UpdateField(ref _EndAngle, value, nameof(EndAngle)); }

    private Decimal? _EndAngle;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Path? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }

    private Path? _Path;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Formulas? Formulas { get => _Formulas; set => UpdateField(ref _Formulas, value, nameof(Formulas)); }

    private Formulas? _Formulas;
    [OpenXmlElement(typeof(DXV.Arc))]
    public ShapeHandles? ShapeHandles { get => _ShapeHandles; set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles)); }

    private ShapeHandles? _ShapeHandles;
    [OpenXmlElement(typeof(DXV.Arc))]
    public DMD.Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

    private DMD.Fill? _Fill;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

    private Stroke? _Stroke;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

    private Shadow? _Shadow;
    [OpenXmlElement(typeof(DXV.Arc))]
    public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

    private TextBox? _TextBox;
    [OpenXmlElement(typeof(DXV.Arc))]
    public TextPath? TextPath { get => _TextPath; set => UpdateField(ref _TextPath, value, nameof(TextPath)); }

    private TextPath? _TextPath;
    [OpenXmlElement(typeof(DXV.Arc))]
    public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

    private ImageData? _ImageData;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

    private Skew? _Skew;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

    private Extrusion? _Extrusion;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

    private Callout? _Callout;
    [OpenXmlElement(typeof(DXV.Arc))]
    public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

    private Lock? _Lock;
    [OpenXmlElement(typeof(DXV.Arc))]
    public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }

    private ClipPath? _ClipPath;
    [OpenXmlElement(typeof(DXV.Arc))]
    public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }

    private SignatureLine? _SignatureLine;
    [OpenXmlElement(typeof(DXV.Arc))]
    public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }

    private TextWrap? _TextWrap;
    [OpenXmlElement(typeof(DXV.Arc))]
    public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

    private bool? _AnchorLock;
    [OpenXmlElement(typeof(DXV.Arc))]
    public BorderType? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

    private BorderType? _TopBorder;
    [OpenXmlElement(typeof(DXV.Arc))]
    public BorderType? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }

    private BorderType? _BottomBorder;
    [OpenXmlElement(typeof(DXV.Arc))]
    public BorderType? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

    private BorderType? _LeftBorder;
    [OpenXmlElement(typeof(DXV.Arc))]
    public BorderType? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

    private BorderType? _RightBorder;
}