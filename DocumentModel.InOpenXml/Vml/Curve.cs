using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
///   Bezier Curve.
/// </summary>
[OpenXmlType(typeof(DXV.Curve))]
public partial class Curve : ModelElement<DXV.Curve>, IEmbeddedObjectContent
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Id))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Shape Styling Properties
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Style))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private string? _Style;
 /// <summary>
 ///   IHyperlink Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Href))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

 private string? _Href;
 /// <summary>
 ///   IHyperlink Display Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Target))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }

 private string? _Target;
 /// <summary>
 ///   CSS Reference
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Class))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }

 private string? _Class;
 /// <summary>
 ///   Shape Title
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Title))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   Alternate Text
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Alternate))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }

 private string? _Alternate;
 /// <summary>
 ///   Coordinate Space Size
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.CoordinateSize))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }

 private string? _CoordinateSize;
 /// <summary>
 ///   Coordinate Space Origin
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.CoordinateOrigin))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? CoordinateOrigin { get => _CoordinateOrigin; set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin)); }

 private string? _CoordinateOrigin;
 /// <summary>
 ///   Shape Bounding Polygon
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.WrapCoordinates))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }

 private string? _WrapCoordinates;
 /// <summary>
 ///   Print Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Print))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }

 private bool? _Print;
 /// <summary>
 ///   Optional String
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.OptionalString))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }

 private string? _OptionalString;
 /// <summary>
 ///   Shape Handle Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Oned))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }

 private bool? _Oned;
 /// <summary>
 ///   Regroup ID
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.RegroupId))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }

 private Int64? _RegroupId;
 /// <summary>
 ///   Double-click Notification Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.DoubleClickNotify))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }

 private bool? _DoubleClickNotify;
 /// <summary>
 ///   Button Behavior Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Button))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }

 private bool? _Button;
 /// <summary>
 ///   Hide Script Anchors
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.UserHidden))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }

 private bool? _UserHidden;
 /// <summary>
 ///   Graphical Bullet
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Bullet))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }

 private bool? _Bullet;
 /// <summary>
 ///   Horizontal Rule Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Horizontal))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }

 private bool? _Horizontal;
 /// <summary>
 ///   Horizontal Rule Standard Display Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.HorizontalStandard))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }

 private bool? _HorizontalStandard;
 /// <summary>
 ///   Horizontal Rule 3D Shading Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.HorizontalNoShade))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }

 private bool? _HorizontalNoShade;
 /// <summary>
 ///   Horizontal Rule Length Percentage
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.HorizontalPercentage))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }

 private Single? _HorizontalPercentage;
 /// <summary>
 ///   Horizontal Rule Alignment
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.HorizontalAlignment))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public HorizontalRuleAlignmentKind? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }

 private HorizontalRuleAlignmentKind? _HorizontalAlignment;
 /// <summary>
 ///   Allow in Table Cell
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.AllowInCell))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

 private bool? _AllowInCell;
 /// <summary>
 ///   Allow Shape Overlap
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.AllowOverlap))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

 private bool? _AllowOverlap;
 /// <summary>
 ///   Exists In Master Slide
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.UserDrawn))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }

 private bool? _UserDrawn;
 /// <summary>
 ///   Border Top Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.BorderTopColor))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? BorderTopColor { get => _BorderTopColor; set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor)); }

 private string? _BorderTopColor;
 /// <summary>
 ///   Border Left Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.BorderLeftColor))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? BorderLeftColor { get => _BorderLeftColor; set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor)); }

 private string? _BorderLeftColor;
 /// <summary>
 ///   Bottom Border Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.BorderBottomColor))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? BorderBottomColor { get => _BorderBottomColor; set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor)); }

 private string? _BorderBottomColor;
 /// <summary>
 ///   Border Right Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.BorderRightColor))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? BorderRightColor { get => _BorderRightColor; set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor)); }

 private string? _BorderRightColor;
 /// <summary>
 ///   Diagram Node Layout Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.DiagramLayout))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }

 private Int64? _DiagramLayout;
 /// <summary>
 ///   Diagram Node Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.DiagramNodeKind))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }

 private Int64? _DiagramNodeKind;
 /// <summary>
 ///   Diagram Node Recent Layout Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.DiagramLayoutMostRecentUsed))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }

 private Int64? _DiagramLayoutMostRecentUsed;
 /// <summary>
 ///   Text Inset Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.InsetMode))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

 private InsetMarginKind? _InsetMode;
 /// <summary>
 ///   Shape Fill Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Filled))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }

 private bool? _Filled;
 /// <summary>
 ///   Fill Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.FillColor))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

 private string? _FillColor;
 /// <summary>
 ///   Shape Stroke Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Stroked))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Stroked { get => _Stroked; set => UpdateField(ref _Stroked, value, nameof(Stroked)); }

 private bool? _Stroked;
 /// <summary>
 ///   Shape Stroke Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.StrokeColor))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

 private string? _StrokeColor;
 /// <summary>
 ///   Shape Stroke Weight
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.StrokeWeight))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? StrokeWeight { get => _StrokeWeight; set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight)); }

 private string? _StrokeWeight;
 /// <summary>
 ///   Inset Border From Path
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.InsetPen))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }

 private bool? _InsetPen;
 /// <summary>
 ///   Optional Number
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.OptionalNumber))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Int32? OptionalNumber { get => _OptionalNumber; set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber)); }

 private Int32? _OptionalNumber;
 /// <summary>
 ///   Shape Connector Type
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.ConnectorType))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public ConnectorKind? ConnectorType { get => _ConnectorType; set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType)); }

 private ConnectorKind? _ConnectorType;
 /// <summary>
 ///   Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.BlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackAndWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   Pure Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.PureBlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }

 private BlackAndWhiteMode? _PureBlackWhiteMode;
 /// <summary>
 ///   Normal Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.NormalBlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }

 private BlackAndWhiteMode? _NormalBlackWhiteMode;
 /// <summary>
 ///   Force Dashed Outline
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.ForceDash))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

 private bool? _ForceDash;
 /// <summary>
 ///   Embedded Object Icon Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.OleIcon))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? OleIcon { get => _OleIcon; set => UpdateField(ref _OleIcon, value, nameof(OleIcon)); }

 private bool? _OleIcon;
 /// <summary>
 ///   Embedded Object Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Ole))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Ole { get => _Ole; set => UpdateField(ref _Ole, value, nameof(Ole)); }

 private bool? _Ole;
 /// <summary>
 ///   Relative Resize Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.PreferRelative))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? PreferRelative { get => _PreferRelative; set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative)); }

 private bool? _PreferRelative;
 /// <summary>
 ///   Clip to Wrapping Polygon
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.ClipToWrap))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? ClipToWrap { get => _ClipToWrap; set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap)); }

 private bool? _ClipToWrap;
 /// <summary>
 ///   Clipping Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Clip))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? Clip { get => _Clip; set => UpdateField(ref _Clip, value, nameof(Clip)); }

 private bool? _Clip;
 /// <summary>
 ///   Encoded Package
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Gfxdata))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public Base64Binary? Gfxdata { get => _Gfxdata; set => UpdateField(ref _Gfxdata, value, nameof(Gfxdata)); }

 private Base64Binary? _Gfxdata;
 /// <summary>
 ///   Curve Starting Point
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.From))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? From { get => _From; set => UpdateField(ref _From, value, nameof(From)); }

 private string? _From;
 /// <summary>
 ///   First Curve Control Point
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Control1))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Control1 { get => _Control1; set => UpdateField(ref _Control1, value, nameof(Control1)); }

 private string? _Control1;
 /// <summary>
 ///   Second Curve Control Point
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.Control2))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? Control2 { get => _Control2; set => UpdateField(ref _Control2, value, nameof(Control2)); }

 private string? _Control2;
 /// <summary>
 ///   Curve Ending Point
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Curve.To))]
 [OpenXmlElement(typeof(DXV.Curve))]
 public string? To { get => _To; set => UpdateField(ref _To, value, nameof(To)); }

 private string? _To;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Path? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }

 private Path? _Path;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Formulas? Formulas { get => _Formulas; set => UpdateField(ref _Formulas, value, nameof(Formulas)); }

 private Formulas? _Formulas;
 [OpenXmlElement(typeof(DXV.Curve))]
 public ShapeHandles? ShapeHandles { get => _ShapeHandles; set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles)); }

 private ShapeHandles? _ShapeHandles;
 [OpenXmlElement(typeof(DXV.Curve))]
 public DMD.Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private DMD.Fill? _Fill;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

 private Stroke? _Stroke;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

 private Shadow? _Shadow;
 [OpenXmlElement(typeof(DXV.Curve))]
 public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

 private TextBox? _TextBox;
 [OpenXmlElement(typeof(DXV.Curve))]
 public TextPath? TextPath { get => _TextPath; set => UpdateField(ref _TextPath, value, nameof(TextPath)); }

 private TextPath? _TextPath;
 [OpenXmlElement(typeof(DXV.Curve))]
 public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

 private ImageData? _ImageData;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

 private Skew? _Skew;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

 private Extrusion? _Extrusion;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

 private Callout? _Callout;
 [OpenXmlElement(typeof(DXV.Curve))]
 public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

 private Lock? _Lock;
 [OpenXmlElement(typeof(DXV.Curve))]
 public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }

 private ClipPath? _ClipPath;
 [OpenXmlElement(typeof(DXV.Curve))]
 public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }

 private SignatureLine? _SignatureLine;
 [OpenXmlElement(typeof(DXV.Curve))]
 public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }

 private TextWrap? _TextWrap;
 [OpenXmlElement(typeof(DXV.Curve))]
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

 private bool? _AnchorLock;
 [OpenXmlElement(typeof(DXV.Curve))]
 public BorderType? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

 private BorderType? _TopBorder;
 [OpenXmlElement(typeof(DXV.Curve))]
 public BorderType? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }

 private BorderType? _BottomBorder;
 [OpenXmlElement(typeof(DXV.Curve))]
 public BorderType? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

 private BorderType? _LeftBorder;
 [OpenXmlElement(typeof(DXV.Curve))]
 public BorderType? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

 private BorderType? _RightBorder;
}