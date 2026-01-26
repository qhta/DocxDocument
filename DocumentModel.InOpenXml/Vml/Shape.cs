using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
///   Shape Definition.
/// </summary>
[OpenXmlType(typeof(DXV.Shape))]
public partial class Shape : ModelElement<DXV.Shape>, IEmbeddedObjectContent
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Id))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Shape Styling Properties
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Style))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private string? _Style;
 /// <summary>
 ///   IHyperlink Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Href))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

 private string? _Href;
 /// <summary>
 ///   IHyperlink Display Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Target))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }

 private string? _Target;
 /// <summary>
 ///   CSS Reference
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Class))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }

 private string? _Class;
 /// <summary>
 ///   Shape Title
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Title))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   Alternate Text
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Alternate))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }

 private string? _Alternate;
 /// <summary>
 ///   Coordinate Space Size
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.CoordinateSize))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }

 private string? _CoordinateSize;
 /// <summary>
 ///   Coordinate Space Origin
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.CoordinateOrigin))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? CoordinateOrigin { get => _CoordinateOrigin; set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin)); }

 private string? _CoordinateOrigin;
 /// <summary>
 ///   Shape Bounding Polygon
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.WrapCoordinates))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }

 private string? _WrapCoordinates;
 /// <summary>
 ///   Print Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Print))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }

 private bool? _Print;
 /// <summary>
 ///   Optional String
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.OptionalString))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }

 private string? _OptionalString;
 /// <summary>
 ///   Shape Handle Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Oned))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }

 private bool? _Oned;
 /// <summary>
 ///   Regroup ID
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.RegroupId))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }

 private Int64? _RegroupId;
 /// <summary>
 ///   Double-click Notification Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.DoubleClickNotify))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }

 private bool? _DoubleClickNotify;
 /// <summary>
 ///   Button Behavior Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Button))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }

 private bool? _Button;
 /// <summary>
 ///   Hide Script Anchors
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.UserHidden))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }

 private bool? _UserHidden;
 /// <summary>
 ///   Graphical Bullet
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Bullet))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }

 private bool? _Bullet;
 /// <summary>
 ///   Horizontal Rule Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Horizontal))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }

 private bool? _Horizontal;
 /// <summary>
 ///   Horizontal Rule Standard Display Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.HorizontalStandard))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }

 private bool? _HorizontalStandard;
 /// <summary>
 ///   Horizontal Rule 3D Shading Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.HorizontalNoShade))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }

 private bool? _HorizontalNoShade;
 /// <summary>
 ///   Horizontal Rule Length Percentage
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.HorizontalPercentage))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }

 private Single? _HorizontalPercentage;
 /// <summary>
 ///   Horizontal Rule Alignment
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.HorizontalAlignment))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public HorizontalRuleAlignmentKind? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }

 private HorizontalRuleAlignmentKind? _HorizontalAlignment;
 /// <summary>
 ///   Allow in Table Cell
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.AllowInCell))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

 private bool? _AllowInCell;
 /// <summary>
 ///   Allow Shape Overlap
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.AllowOverlap))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

 private bool? _AllowOverlap;
 /// <summary>
 ///   Exists In Master Slide
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.UserDrawn))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }

 private bool? _UserDrawn;
 /// <summary>
 ///   Border Top Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.BorderTopColor))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? BorderTopColor { get => _BorderTopColor; set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor)); }

 private string? _BorderTopColor;
 /// <summary>
 ///   Border Left Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.BorderLeftColor))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? BorderLeftColor { get => _BorderLeftColor; set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor)); }

 private string? _BorderLeftColor;
 /// <summary>
 ///   Bottom Border Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.BorderBottomColor))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? BorderBottomColor { get => _BorderBottomColor; set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor)); }

 private string? _BorderBottomColor;
 /// <summary>
 ///   Border Right Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.BorderRightColor))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? BorderRightColor { get => _BorderRightColor; set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor)); }

 private string? _BorderRightColor;
 /// <summary>
 ///   Diagram Node Layout Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.DiagramLayout))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }

 private Int64? _DiagramLayout;
 /// <summary>
 ///   Diagram Node Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.DiagramNodeKind))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }

 private Int64? _DiagramNodeKind;
 /// <summary>
 ///   Diagram Node Recent Layout Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.DiagramLayoutMostRecentUsed))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }

 private Int64? _DiagramLayoutMostRecentUsed;
 /// <summary>
 ///   Text Inset Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.InsetMode))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

 private InsetMarginKind? _InsetMode;
 /// <summary>
 ///   Shape Fill Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Filled))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }

 private bool? _Filled;
 /// <summary>
 ///   Fill Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.FillColor))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

 private string? _FillColor;
 /// <summary>
 ///   Shape Stroke Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Stroked))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Stroked { get => _Stroked; set => UpdateField(ref _Stroked, value, nameof(Stroked)); }

 private bool? _Stroked;
 /// <summary>
 ///   Shape Stroke Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.StrokeColor))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

 private string? _StrokeColor;
 /// <summary>
 ///   Shape Stroke Weight
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.StrokeWeight))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? StrokeWeight { get => _StrokeWeight; set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight)); }

 private string? _StrokeWeight;
 /// <summary>
 ///   Inset Border From Path
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.InsetPen))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }

 private bool? _InsetPen;
 /// <summary>
 ///   Optional Number
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.OptionalNumber))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Int32? OptionalNumber { get => _OptionalNumber; set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber)); }

 private Int32? _OptionalNumber;
 /// <summary>
 ///   Shape Connector Type
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.ConnectorType))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public ConnectorKind? ConnectorType { get => _ConnectorType; set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType)); }

 private ConnectorKind? _ConnectorType;
 /// <summary>
 ///   Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.BlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackAndWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   Pure Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.PureBlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }

 private BlackAndWhiteMode? _PureBlackWhiteMode;
 /// <summary>
 ///   Normal Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.NormalBlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }

 private BlackAndWhiteMode? _NormalBlackWhiteMode;
 /// <summary>
 ///   Force Dashed Outline
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.ForceDash))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

 private bool? _ForceDash;
 /// <summary>
 ///   Embedded Object Icon Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.OleIcon))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? OleIcon { get => _OleIcon; set => UpdateField(ref _OleIcon, value, nameof(OleIcon)); }

 private bool? _OleIcon;
 /// <summary>
 ///   Embedded Object Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Ole))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Ole { get => _Ole; set => UpdateField(ref _Ole, value, nameof(Ole)); }

 private bool? _Ole;
 /// <summary>
 ///   Relative Resize Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.PreferRelative))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? PreferRelative { get => _PreferRelative; set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative)); }

 private bool? _PreferRelative;
 /// <summary>
 ///   Clip to Wrapping Polygon
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.ClipToWrap))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? ClipToWrap { get => _ClipToWrap; set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap)); }

 private bool? _ClipToWrap;
 /// <summary>
 ///   Clipping Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Clip))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? Clip { get => _Clip; set => UpdateField(ref _Clip, value, nameof(Clip)); }

 private bool? _Clip;
 /// <summary>
 ///   Shape Type Reference
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Type))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private string? _Type;
 /// <summary>
 ///   Adjustment Parameters
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.Adjustment))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? Adjustment { get => _Adjustment; set => UpdateField(ref _Adjustment, value, nameof(Adjustment)); }

 private string? _Adjustment;
 /// <summary>
 ///   Edge Path
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.EdgePath))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? EdgePath { get => _EdgePath; set => UpdateField(ref _EdgePath, value, nameof(EdgePath)); }

 private string? _EdgePath;
 /// <summary>
 ///   Encoded Package
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.EncodedPackage))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public Base64Binary? EncodedPackage { get => _EncodedPackage; set => UpdateField(ref _EncodedPackage, value, nameof(EncodedPackage)); }

 private Base64Binary? _EncodedPackage;
 /// <summary>
 ///   Storage for Alternate Math Content
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Shape.EquationXml))]
 [OpenXmlElement(typeof(DXV.Shape))]
 public string? EquationXml { get => _EquationXml; set => UpdateField(ref _EquationXml, value, nameof(EquationXml)); }

 private string? _EquationXml;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Path? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }

 private Path? _Path;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Formulas? Formulas { get => _Formulas; set => UpdateField(ref _Formulas, value, nameof(Formulas)); }

 private Formulas? _Formulas;
 [OpenXmlElement(typeof(DXV.Shape))]
 public ShapeHandles? ShapeHandles { get => _ShapeHandles; set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles)); }

 private ShapeHandles? _ShapeHandles;
 [OpenXmlElement(typeof(DXV.Shape))]
 public DMD.Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private DMD.Fill? _Fill;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

 private Stroke? _Stroke;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

 private Shadow? _Shadow;
 [OpenXmlElement(typeof(DXV.Shape))]
 public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

 private TextBox? _TextBox;
 [OpenXmlElement(typeof(DXV.Shape))]
 public TextPath? TextPath { get => _TextPath; set => UpdateField(ref _TextPath, value, nameof(TextPath)); }

 private TextPath? _TextPath;
 [OpenXmlElement(typeof(DXV.Shape))]
 public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

 private ImageData? _ImageData;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

 private Skew? _Skew;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

 private Extrusion? _Extrusion;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

 private Callout? _Callout;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

 private Lock? _Lock;
 [OpenXmlElement(typeof(DXV.Shape))]
 public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }

 private ClipPath? _ClipPath;
 [OpenXmlElement(typeof(DXV.Shape))]
 public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }

 private SignatureLine? _SignatureLine;
 [OpenXmlElement(typeof(DXV.Shape))]
 public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }

 private TextWrap? _TextWrap;
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

 private bool? _AnchorLock;
 [OpenXmlElement(typeof(DXV.Shape))]
 public BorderType? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

 private BorderType? _TopBorder;
 [OpenXmlElement(typeof(DXV.Shape))]
 public BorderType? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }

 private BorderType? _BottomBorder;
 [OpenXmlElement(typeof(DXV.Shape))]
 public BorderType? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

 private BorderType? _LeftBorder;
 [OpenXmlElement(typeof(DXV.Shape))]
 public BorderType? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

 private BorderType? _RightBorder;
 [OpenXmlElement(typeof(DXV.Shape))]
 public Ink? Ink { get => _Ink; set => UpdateField(ref _Ink, value, nameof(Ink)); }

 private Ink? _Ink;
 [OpenXmlElement(typeof(DXV.Shape))]
 public bool? InkAnnotationFlag { get => _InkAnnotationFlag; set => UpdateField(ref _InkAnnotationFlag, value, nameof(InkAnnotationFlag)); }

 private bool? _InkAnnotationFlag;
}