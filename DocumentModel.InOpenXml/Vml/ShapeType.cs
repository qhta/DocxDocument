using DocumentFormat.OpenXml.EMMA;
using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
/// Represents a shape template in a VML drawing, providing properties for styling, positioning, behavior, and embedded content.
/// This class enables advanced customization and management of VML shapes, including hyperlinks, CSS references, coordinate space, borders, fill, stroke, shadow, text, image data, and more.
/// </summary>
[OpenXmlType(typeof(DXV.Shapetype))]
[DataContract]
[XmlRoot("ShapeType", Namespace = "DocumentModel.Vml")]
public partial class ShapeType : ModelElement<DXV.Shapetype>, IEmbeddedObjectContent
{
 /// <summary>
 /// Unique identifier for the shape template.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;

 /// <summary>
 /// Shape styling properties, specified as a CSS style string.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Style))]
 public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }
 private string? _Style;

 /// <summary>
 /// Hyperlink target for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Href))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }
 private string? _Href;

 /// <summary>
 /// Hyperlink display target for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Target))]
 public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }
 private string? _Target;

 /// <summary>
 /// CSS class reference for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Class))]
 public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }
 private string? _Class;

 /// <summary>
 /// Title of the shape, used for accessibility and tooltips.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Title))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }
 private string? _Title;

 /// <summary>
 /// Alternate text for the shape, used for accessibility.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Alternate))]
 public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }
 private string? _Alternate;

 /// <summary>
 /// Coordinate space size for the shape, specifying the width and height of the coordinate system.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.CoordinateSize))]
 public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }
 private string? _CoordinateSize;

 /// <summary>
 /// Coordinate space origin for the shape, specifying the starting point of the coordinate system.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.CoordinateOrigin))]
 public string? CoordinateOrigin { get => _CoordinateOrigin; set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin)); }
 private string? _CoordinateOrigin;

 /// <summary>
 /// Shape bounding polygon coordinates for text wrapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.WrapCoordinates))]
 public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }
 private string? _WrapCoordinates;

 /// <summary>
 /// Indicates whether the shape should be printed.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Print))]
 public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }
 private bool? _Print;

 /// <summary>
 /// Optional string for additional shape data.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.OptionalString))]
 public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }
 private string? _OptionalString;

 /// <summary>
 /// Indicates whether the shape handle is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Oned))]
 public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }
 private bool? _Oned;

 /// <summary>
 /// Regroup ID for the shape, used for grouping shapes.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.RegroupId))]
 public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }
 private Int64? _RegroupId;

 /// <summary>
 /// Indicates whether double-click notification is enabled for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.DoubleClickNotify))]
 public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }
 private bool? _DoubleClickNotify;

 /// <summary>
 /// Indicates whether button behavior is enabled for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Button))]
 public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }
 private bool? _Button;

 /// <summary>
 /// Indicates whether script anchors are hidden for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.UserHidden))]
 public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }
 private bool? _UserHidden;

 /// <summary>
 /// Indicates whether the shape is a graphical bullet.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Bullet))]
 public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }
 private bool? _Bullet;

 /// <summary>
 /// Indicates whether the shape is a horizontal rule.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Horizontal))]
 public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }
 private bool? _Horizontal;

 /// <summary>
 /// Indicates whether the horizontal rule is displayed in standard mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.HorizontalStandard))]
 public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }
 private bool? _HorizontalStandard;

 /// <summary>
 /// Indicates whether 3D shading is applied to the horizontal rule.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.HorizontalNoShade))]
 public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }
 private bool? _HorizontalNoShade;

 /// <summary>
 /// Length percentage of the horizontal rule.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.HorizontalPercentage))]
 public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }
 private Single? _HorizontalPercentage;

 /// <summary>
 /// Alignment of the horizontal rule.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.HorizontalAlignment))]
 public HorizontalRuleAlignment? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }
 private HorizontalRuleAlignment? _HorizontalAlignment;

 /// <summary>
 /// Indicates whether the shape is allowed in a table cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.AllowInCell))]
 public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }
 private bool? _AllowInCell;

 /// <summary>
 /// Indicates whether shape overlap is allowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.AllowOverlap))]
 public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }
 private bool? _AllowOverlap;

 /// <summary>
 /// Indicates whether the shape exists in the master slide.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.UserDrawn))]
 public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }
 private bool? _UserDrawn;

 /// <summary>
 /// Top border color of the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.BorderTopColor))]
 public VmlColor? BorderTopColor { get => _BorderTopColor; set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor)); }
 private VmlColor? _BorderTopColor;

 /// <summary>
 /// Left border color of the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.BorderLeftColor))]
 public VmlColor? BorderLeftColor { get => _BorderLeftColor; set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor)); }
 private VmlColor? _BorderLeftColor;

 /// <summary>
 /// Bottom border color of the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.BorderBottomColor))]
 public VmlColor? BorderBottomColor { get => _BorderBottomColor; set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor)); }
 private VmlColor? _BorderBottomColor;

 /// <summary>
 /// Right border color of the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.BorderRightColor))]
 public VmlColor? BorderRightColor { get => _BorderRightColor; set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor)); }
 private VmlColor? _BorderRightColor;

 /// <summary>
 /// Diagram node layout identifier for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.DiagramLayout))]
 public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }
 private Int64? _DiagramLayout;

 /// <summary>
 /// Diagram node kind identifier for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.DiagramNodeKind))]
 public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }
 private Int64? _DiagramNodeKind;

 /// <summary>
 /// Diagram node recent layout identifier for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.DiagramLayoutMostRecentUsed))]
 public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }
 private Int64? _DiagramLayoutMostRecentUsed;

 /// <summary>
 /// Text inset mode for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.InsetMode))]
 public InsetMargin? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }
 private InsetMargin? _InsetMode;

 /// <summary>
 /// Indicates whether the shape is filled.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Filled))]
 public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }
 private bool? _Filled;

 /// <summary>
 /// Fill color for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.FillColor))]
 public VmlColor? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }
 private VmlColor? _FillColor;

 /// <summary>
 /// Indicates whether the shape is stroked.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Stroked))]
 public bool? Stroked { get => _Stroked; set => UpdateField(ref _Stroked, value, nameof(Stroked)); }
 private bool? _Stroked;

 /// <summary>
 /// Stroke color for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.StrokeColor))]
 public VmlColor? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }
 private VmlColor? _StrokeColor;

 /// <summary>
 /// Stroke weight for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.StrokeWeight))]
 public string? StrokeWeight { get => _StrokeWeight; set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight)); }
 private string? _StrokeWeight;

 /// <summary>
 /// Indicates whether the border is inset from the path.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.InsetPen))]
 public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }
 private bool? _InsetPen;

 /// <summary>
 /// Optional number for additional shape data.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.OptionalNumber))]
 public Int32? OptionalNumber { get => _OptionalNumber; set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber)); }
 private Int32? _OptionalNumber;

 /// <summary>
 /// Connector type for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.ConnectorType))]
 public ConnectorType? ConnectorType { get => _ConnectorType; set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType)); }
 private ConnectorType? _ConnectorType;

 /// <summary>
 /// Black-and-white mode for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.BlackWhiteMode))]
 public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }
 private BlackAndWhiteMode? _BlackWhiteMode;

 /// <summary>
 /// Pure black-and-white mode for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.PureBlackWhiteMode))]
 public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }
 private BlackAndWhiteMode? _PureBlackWhiteMode;

 /// <summary>
 /// Normal black-and-white mode for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.NormalBlackWhiteMode))]
 public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }
 private BlackAndWhiteMode? _NormalBlackWhiteMode;

 /// <summary>
 /// Indicates whether a dashed outline is forced for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.ForceDash))]
 public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }
 private bool? _ForceDash;

 /// <summary>
 /// Indicates whether the shape is an embedded object icon.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.OleIcon))]
 public bool? OleIcon { get => _OleIcon; set => UpdateField(ref _OleIcon, value, nameof(OleIcon)); }
 private bool? _OleIcon;

 /// <summary>
 /// Indicates whether the shape is an embedded object.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Ole))]
 public bool? Ole { get => _Ole; set => UpdateField(ref _Ole, value, nameof(Ole)); }
 private bool? _Ole;

 /// <summary>
 /// Indicates whether relative resize is preferred for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.PreferRelative))]
 public bool? PreferRelative { get => _PreferRelative; set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative)); }
 private bool? _PreferRelative;

 /// <summary>
 /// Indicates whether the shape should be clipped to the wrapping polygon.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.ClipToWrap))]
 public bool? ClipToWrap { get => _ClipToWrap; set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap)); }
 private bool? _ClipToWrap;

 /// <summary>
 /// Indicates whether clipping is enabled for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Clip))]
 public bool? Clip { get => _Clip; set => UpdateField(ref _Clip, value, nameof(Clip)); }
 private bool? _Clip;

 /// <summary>
 /// Adjustment parameters for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Adjustment))]
 public string? Adjustment { get => _Adjustment; set => UpdateField(ref _Adjustment, value, nameof(Adjustment)); }
 private string? _Adjustment;

 /// <summary>
 /// Edge path for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.EdgePath))]
 public string? EdgePath { get => _EdgePath; set => UpdateField(ref _EdgePath, value, nameof(EdgePath)); }
 private string? _EdgePath;

 /// <summary>
 /// Master element toggle for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shapetype.Master))]
 public string? Master { get => _Master; set => UpdateField(ref _Master, value, nameof(Master)); }
 private string? _Master;

 /// <summary>
 /// Path element for the shape, specifying the geometry.
 /// </summary>
 public Path? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }
 private Path? _Path;

 /// <summary>
 /// Formulas element for the shape, specifying calculation formulas.
 /// </summary>
 public Formulas? Formulas { get => _Formulas; set => UpdateField(ref _Formulas, value, nameof(Formulas)); }
 private Formulas? _Formulas;

 /// <summary>
 /// Shape handles element for the shape, specifying interactive handles.
 /// </summary>
 public ShapeHandles? ShapeHandles { get => _ShapeHandles; set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles)); }
 private ShapeHandles? _ShapeHandles;

 /// <summary>
 /// Fill element for the shape, specifying fill formatting.
 /// </summary>
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
 private Fill? _Fill;

 /// <summary>
 /// Stroke element for the shape, specifying stroke formatting.
 /// </summary>
 public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }
 private Stroke? _Stroke;

 /// <summary>
 /// Shadow element for the shape, specifying shadow formatting.
 /// </summary>
 public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }
 private Shadow? _Shadow;

 /// <summary>
 /// Text box element for the shape, specifying text layout and formatting.
 /// </summary>
 public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }
 private TextBox? _TextBox;

 /// <summary>
 /// Text path element for the shape, specifying text path formatting.
 /// </summary>
 public TextPath? TextPath { get => _TextPath; set => UpdateField(ref _TextPath, value, nameof(TextPath)); }
 private TextPath? _TextPath;

 /// <summary>
 /// Image data element for the shape, specifying embedded image content.
 /// </summary>
 public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }
 private ImageData? _ImageData;

 /// <summary>
 /// Skew element for the shape, specifying skew transformation.
 /// </summary>
 public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }
 private Skew? _Skew;

 /// <summary>
 /// Extrusion element for the shape, specifying 3D extrusion formatting.
 /// </summary>
 public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }
 private Extrusion? _Extrusion;

 /// <summary>
 /// Callout element for the shape, specifying callout formatting.
 /// </summary>
 public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }
 private Callout? _Callout;

 /// <summary>
 /// Lock element for the shape, specifying locking options.
 /// </summary>
 public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }
 private Lock? _Lock;

 /// <summary>
 /// Clip path element for the shape, specifying a custom clipping path.
 /// </summary>
 public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }
 private ClipPath? _ClipPath;

 /// <summary>
 /// Signature line element for the shape, specifying digital signature options.
 /// </summary>
 public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }
 private SignatureLine? _SignatureLine;

 /// <summary>
 /// Text wrap element for the shape, specifying text wrapping options.
 /// </summary>
 public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }
 private TextWrap? _TextWrap;

 /// <summary>
 /// Indicates whether the shape anchor is locked.
 /// </summary>
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }
 private bool? _AnchorLock;

 /// <summary>
 /// Top border type for the shape.
 /// </summary>
 public Border? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }
 private Border? _TopBorder;

 /// <summary>
 /// Bottom border type for the shape.
 /// </summary>
 public Border? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }
 private Border? _BottomBorder;

 /// <summary>
 /// Left border type for the shape.
 /// </summary>
 public Border? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }
 private Border? _LeftBorder;

 /// <summary>
 /// Right border type for the shape.
 /// </summary>
 public Border? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }
 private Border? _RightBorder;

 /// <summary>
 /// Complex element for the shape, specifying advanced formatting or behavior.
 /// </summary>
 public Complex? Complex { get => _Complex; set => UpdateField(ref _Complex, value, nameof(Complex)); }
 private Complex? _Complex;
}