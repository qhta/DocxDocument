using DocumentFormat.OpenXml.EMMA;
using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
///   Image File.
/// </summary>
[OpenXmlType(typeof(DXV.ImageFile))]
public partial class ImageFile : ModelElement<DXV.ImageFile>, IEmbeddedObjectContent
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Id))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   style
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Style))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private string? _Style;
 /// <summary>
 ///   href
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Href))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

 private string? _Href;
 /// <summary>
 ///   target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Target))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }

 private string? _Target;
 /// <summary>
 ///   interface
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Class))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }

 private string? _Class;
 /// <summary>
 ///   title
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Title))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   alt
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Alternate))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }

 private string? _Alternate;
 /// <summary>
 ///   coordsize
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.CoordinateSize))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }

 private string? _CoordinateSize;
 /// <summary>
 ///   wrapcoords
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.WrapCoordinates))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }

 private string? _WrapCoordinates;
 /// <summary>
 ///   print
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Print))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }

 private bool? _Print;
 /// <summary>
 ///   Optional String
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.OptionalString))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }

 private string? _OptionalString;
 /// <summary>
 ///   Shape Handle Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Oned))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }

 private bool? _Oned;
 /// <summary>
 ///   Regroup ID
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.RegroupId))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }

 private Int64? _RegroupId;
 /// <summary>
 ///   Double-click Notification Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.DoubleClickNotify))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }

 private bool? _DoubleClickNotify;
 /// <summary>
 ///   Button Behavior Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Button))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }

 private bool? _Button;
 /// <summary>
 ///   Hide Script Anchors
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.UserHidden))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }

 private bool? _UserHidden;
 /// <summary>
 ///   Graphical Bullet
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Bullet))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }

 private bool? _Bullet;
 /// <summary>
 ///   Horizontal Rule Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Horizontal))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }

 private bool? _Horizontal;
 /// <summary>
 ///   Horizontal Rule Standard Display Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.HorizontalStandard))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }

 private bool? _HorizontalStandard;
 /// <summary>
 ///   Horizontal Rule 3D Shading Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.HorizontalNoShade))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }

 private bool? _HorizontalNoShade;
 /// <summary>
 ///   Horizontal Rule Length Percentage
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.HorizontalPercentage))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }

 private Single? _HorizontalPercentage;
 /// <summary>
 ///   Horizontal Rule Alignment
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.HorizontalAlignment))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public HorizontalRuleAlignmentKind? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }

 private HorizontalRuleAlignmentKind? _HorizontalAlignment;
 /// <summary>
 ///   Allow in Table Cell
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.AllowInCell))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

 private bool? _AllowInCell;
 /// <summary>
 ///   Allow Shape Overlap
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.AllowOverlap))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

 private bool? _AllowOverlap;
 /// <summary>
 ///   Exists In Master Slide
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.UserDrawn))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }

 private bool? _UserDrawn;
 /// <summary>
 ///   Border Top Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BorderTopColor))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? BorderTopColor { get => _BorderTopColor; set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor)); }

 private string? _BorderTopColor;
 /// <summary>
 ///   Border Left Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BorderLeftColor))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? BorderLeftColor { get => _BorderLeftColor; set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor)); }

 private string? _BorderLeftColor;
 /// <summary>
 ///   Bottom Border Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BorderBottomColor))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? BorderBottomColor { get => _BorderBottomColor; set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor)); }

 private string? _BorderBottomColor;
 /// <summary>
 ///   Border Right Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BorderRightColor))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? BorderRightColor { get => _BorderRightColor; set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor)); }

 private string? _BorderRightColor;
 /// <summary>
 ///   Diagram Node Layout Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.DiagramLayout))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }

 private Int64? _DiagramLayout;
 /// <summary>
 ///   Diagram Node Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.DiagramNodeKind))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }

 private Int64? _DiagramNodeKind;
 /// <summary>
 ///   Diagram Node Recent Layout Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.DiagramLayoutMostRecentUsed))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }

 private Int64? _DiagramLayoutMostRecentUsed;
 /// <summary>
 ///   Text Inset Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.InsetMode))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

 private InsetMarginKind? _InsetMode;
 /// <summary>
 ///   Shape Fill Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Filled))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }

 private bool? _Filled;
 /// <summary>
 ///   Fill Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.FillColor))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

 private string? _FillColor;
 /// <summary>
 ///   Shape Stroke Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Stroked))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Stroked { get => _Stroked; set => UpdateField(ref _Stroked, value, nameof(Stroked)); }

 private bool? _Stroked;
 /// <summary>
 ///   Shape Stroke Color
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.StrokeColor))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

 private string? _StrokeColor;
 /// <summary>
 ///   Shape Stroke Weight
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.StrokeWeight))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? StrokeWeight { get => _StrokeWeight; set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight)); }

 private string? _StrokeWeight;
 /// <summary>
 ///   Inset Border From Path
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.InsetPen))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }

 private bool? _InsetPen;
 /// <summary>
 ///   Optional Number
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.OptionalNumber))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Int32? OptionalNumber { get => _OptionalNumber; set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber)); }

 private Int32? _OptionalNumber;
 /// <summary>
 ///   Shape Connector Type
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.ConnectorType))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public ConnectorKind? ConnectorType { get => _ConnectorType; set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType)); }

 private ConnectorKind? _ConnectorType;
 /// <summary>
 ///   Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackAndWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   Pure Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.PureBlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }

 private BlackAndWhiteMode? _PureBlackWhiteMode;
 /// <summary>
 ///   Normal Black-and-White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.NormalBlackWhiteMode))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }

 private BlackAndWhiteMode? _NormalBlackWhiteMode;
 /// <summary>
 ///   Force Dashed Outline
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.ForceDash))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

 private bool? _ForceDash;
 /// <summary>
 ///   Embedded Object Icon Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.OleIcon))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? OleIcon { get => _OleIcon; set => UpdateField(ref _OleIcon, value, nameof(OleIcon)); }

 private bool? _OleIcon;
 /// <summary>
 ///   Embedded Object Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Ole))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Ole { get => _Ole; set => UpdateField(ref _Ole, value, nameof(Ole)); }

 private bool? _Ole;
 /// <summary>
 ///   Relative Resize Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.PreferRelative))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? PreferRelative { get => _PreferRelative; set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative)); }

 private bool? _PreferRelative;
 /// <summary>
 ///   Clip to Wrapping Polygon
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.ClipToWrap))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? ClipToWrap { get => _ClipToWrap; set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap)); }

 private bool? _ClipToWrap;
 /// <summary>
 ///   Clipping Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Clip))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? Clip { get => _Clip; set => UpdateField(ref _Clip, value, nameof(Clip)); }

 private bool? _Clip;
 /// <summary>
 ///   Image Source
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Source))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Source { get => _Source; set => UpdateField(ref _Source, value, nameof(Source)); }

 private string? _Source;
 /// <summary>
 ///   Image Left Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.CropLeft))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? CropLeft { get => _CropLeft; set => UpdateField(ref _CropLeft, value, nameof(CropLeft)); }

 private string? _CropLeft;
 /// <summary>
 ///   Image Top Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.CropTop))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? CropTop { get => _CropTop; set => UpdateField(ref _CropTop, value, nameof(CropTop)); }

 private string? _CropTop;
 /// <summary>
 ///   Image Right Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.CropRight))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? CropRight { get => _CropRight; set => UpdateField(ref _CropRight, value, nameof(CropRight)); }

 private string? _CropRight;
 /// <summary>
 ///   Image Bottom Crop
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.CropBottom))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? CropBottom { get => _CropBottom; set => UpdateField(ref _CropBottom, value, nameof(CropBottom)); }

 private string? _CropBottom;
 /// <summary>
 ///   Image Intensity
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Gain))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Gain { get => _Gain; set => UpdateField(ref _Gain, value, nameof(Gain)); }

 private string? _Gain;
 /// <summary>
 ///   Image Brightness
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BlackLevel))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? BlackLevel { get => _BlackLevel; set => UpdateField(ref _BlackLevel, value, nameof(BlackLevel)); }

 private string? _BlackLevel;
 /// <summary>
 ///   Image Gamma Correction
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Gamma))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public string? Gamma { get => _Gamma; set => UpdateField(ref _Gamma, value, nameof(Gamma)); }

 private string? _Gamma;
 /// <summary>
 ///   Image Grayscale Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.GrayScale))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Boolean GrayScale { get => _GrayScale; set => UpdateField(ref _GrayScale, value, nameof(GrayScale)); }

 private Boolean _GrayScale;
 /// <summary>
 ///   Image Bilevel Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.BiLevel))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? BiLevel { get => _BiLevel; set => UpdateField(ref _BiLevel, value, nameof(BiLevel)); }

 private bool? _BiLevel;
 /// <summary>
 ///   Encoded Package
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ImageFile.Gfxdata))]
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Base64Binary? Gfxdata { get => _Gfxdata; set => UpdateField(ref _Gfxdata, value, nameof(Gfxdata)); }

 private Base64Binary? _Gfxdata;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Path? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }

 private Path? _Path;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Formulas? Formulas { get => _Formulas; set => UpdateField(ref _Formulas, value, nameof(Formulas)); }

 private Formulas? _Formulas;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public ShapeHandles? ShapeHandles { get => _ShapeHandles; set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles)); }

 private ShapeHandles? _ShapeHandles;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public DMD.Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private DMD.Fill? _Fill;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

 private Stroke? _Stroke;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

 private Shadow? _Shadow;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

 private TextBox? _TextBox;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public TextPath? TextPath { get => _TextPath; set => UpdateField(ref _TextPath, value, nameof(TextPath)); }

 private TextPath? _TextPath;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

 private ImageData? _ImageData;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

 private Skew? _Skew;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

 private Extrusion? _Extrusion;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

 private Callout? _Callout;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

 private Lock? _Lock;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }

 private ClipPath? _ClipPath;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }

 private SignatureLine? _SignatureLine;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }

 private TextWrap? _TextWrap;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

 private bool? _AnchorLock;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BorderType? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

 private BorderType? _TopBorder;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BorderType? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }

 private BorderType? _BottomBorder;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BorderType? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

 private BorderType? _LeftBorder;
 [OpenXmlElement(typeof(DXV.ImageFile))]
 public BorderType? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

 private BorderType? _RightBorder;
}