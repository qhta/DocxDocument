using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
///   Shape Group.
/// </summary>
[OpenXmlType(typeof(DXV.Group))]
public partial class Group : ModelElement<DXV.Group>, IEmbeddedObjectContent
{
 /// <summary>
 ///   Unique Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Id))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Shape Styling Properties
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Style))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private string? _Style;
 /// <summary>
 ///   IHyperlink Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Href))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

 private string? _Href;
 /// <summary>
 ///   IHyperlink Display Target
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Target))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }

 private string? _Target;
 /// <summary>
 ///   CSS Reference
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Class))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }

 private string? _Class;
 /// <summary>
 ///   Shape Title
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Title))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

 private string? _Title;
 /// <summary>
 ///   Alternate Text
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Alternate))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }

 private string? _Alternate;
 /// <summary>
 ///   Coordinate Space Size
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.CoordinateSize))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }

 private string? _CoordinateSize;
 /// <summary>
 ///   Coordinate Space Origin
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.CoordinateOrigin))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? CoordinateOrigin { get => _CoordinateOrigin; set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin)); }

 private string? _CoordinateOrigin;
 /// <summary>
 ///   Shape Bounding Polygon
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.WrapCoordinates))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }

 private string? _WrapCoordinates;
 /// <summary>
 ///   Print Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Print))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }

 private bool? _Print;
 /// <summary>
 ///   spid
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.OptionalString))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }

 private string? _OptionalString;
 /// <summary>
 ///   oned
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Oned))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }

 private bool? _Oned;
 /// <summary>
 ///   regroupid
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.RegroupId))]
 [OpenXmlElement(typeof(DXV.Group))]
 public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }

 private Int64? _RegroupId;
 /// <summary>
 ///   doubleclicknotify
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.DoubleClickNotify))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }

 private bool? _DoubleClickNotify;
 /// <summary>
 ///   button
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Button))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }

 private bool? _Button;
 /// <summary>
 ///   userhidden
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.UserHidden))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }

 private bool? _UserHidden;
 /// <summary>
 ///   bullet
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Bullet))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }

 private bool? _Bullet;
 /// <summary>
 ///   hr
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Horizontal))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }

 private bool? _Horizontal;
 /// <summary>
 ///   hrstd
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.HorizontalStandard))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }

 private bool? _HorizontalStandard;
 /// <summary>
 ///   hrnoshade
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.HorizontalNoShade))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }

 private bool? _HorizontalNoShade;
 /// <summary>
 ///   hrpct
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.HorizontalPercentage))]
 [OpenXmlElement(typeof(DXV.Group))]
 public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }

 private Single? _HorizontalPercentage;
 /// <summary>
 ///   hralign
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.HorizontalAlignment))]
 [OpenXmlElement(typeof(DXV.Group))]
 public HorizontalRuleAlignmentKind? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }

 private HorizontalRuleAlignmentKind? _HorizontalAlignment;
 /// <summary>
 ///   allowincell
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.AllowInCell))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

 private bool? _AllowInCell;
 /// <summary>
 ///   allowoverlap
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.AllowOverlap))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

 private bool? _AllowOverlap;
 /// <summary>
 ///   userdrawn
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.UserDrawn))]
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }

 private bool? _UserDrawn;
 /// <summary>
 ///   dgmlayout
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.DiagramLayout))]
 [OpenXmlElement(typeof(DXV.Group))]
 public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }

 private Int64? _DiagramLayout;
 /// <summary>
 ///   dgmnodekind
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.DiagramNodeKind))]
 [OpenXmlElement(typeof(DXV.Group))]
 public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }

 private Int64? _DiagramNodeKind;
 /// <summary>
 ///   dgmlayoutmru
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.DiagramLayoutMostRecentUsed))]
 [OpenXmlElement(typeof(DXV.Group))]
 public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }

 private Int64? _DiagramLayoutMostRecentUsed;
 /// <summary>
 ///   insetmode
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.InsetMode))]
 [OpenXmlElement(typeof(DXV.Group))]
 public InsetMarginKind? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

 private InsetMarginKind? _InsetMode;
 /// <summary>
 ///   Encoded Package
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.Gfxdata))]
 [OpenXmlElement(typeof(DXV.Group))]
 public Base64Binary? Gfxdata { get => _Gfxdata; set => UpdateField(ref _Gfxdata, value, nameof(Gfxdata)); }

 private Base64Binary? _Gfxdata;
 /// <summary>
 ///   Group Diagram Type
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.EditAs))]
 [OpenXmlElement(typeof(DXV.Group))]
 public EditAsKind? EditAs { get => _EditAs; set => UpdateField(ref _EditAs, value, nameof(EditAs)); }

 private EditAsKind? _EditAs;
 /// <summary>
 ///   Table Properties
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.TableProperties))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? TableProperties { get => _TableProperties; set => UpdateField(ref _TableProperties, value, nameof(TableProperties)); }

 private string? _TableProperties;
 /// <summary>
 ///   Table Row Height Limits
 /// </summary>
 [OpenXmlProperty(nameof(DXV.Group.TableLimits))]
 [OpenXmlElement(typeof(DXV.Group))]
 public string? TableLimits { get => _TableLimits; set => UpdateField(ref _TableLimits, value, nameof(TableLimits)); }

 private string? _TableLimits;
 [OpenXmlElement(typeof(DXV.Group))]
 public Group? ChildGroup { get => _ChildGroup; set => UpdateField(ref _ChildGroup, value, nameof(ChildGroup)); }

 private Group? _ChildGroup;
 [OpenXmlElement(typeof(DXV.Group))]
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

 private Shape? _Shape;
 [OpenXmlElement(typeof(DXV.Group))]
 public ShapeType? Shapetype { get => _Shapetype; set => UpdateField(ref _Shapetype, value, nameof(Shapetype)); }

 private ShapeType? _Shapetype;
 [OpenXmlElement(typeof(DXV.Group))]
 public Arc? Arc { get => _Arc; set => UpdateField(ref _Arc, value, nameof(Arc)); }

 private Arc? _Arc;
 [OpenXmlElement(typeof(DXV.Group))]
 public Curve? Curve { get => _Curve; set => UpdateField(ref _Curve, value, nameof(Curve)); }

 private Curve? _Curve;
 [OpenXmlElement(typeof(DXV.Group))]
 public ImageFile? ImageFile { get => _ImageFile; set => UpdateField(ref _ImageFile, value, nameof(ImageFile)); }

 private ImageFile? _ImageFile;
 [OpenXmlElement(typeof(DXV.Group))]
 public Line? Line { get => _Line; set => UpdateField(ref _Line, value, nameof(Line)); }

 private Line? _Line;
 [OpenXmlElement(typeof(DXV.Group))]
 public Oval? Oval { get => _Oval; set => UpdateField(ref _Oval, value, nameof(Oval)); }

 private Oval? _Oval;
 [OpenXmlElement(typeof(DXV.Group))]
 public PolyLine? PolyLine { get => _PolyLine; set => UpdateField(ref _PolyLine, value, nameof(PolyLine)); }

 private PolyLine? _PolyLine;
 [OpenXmlElement(typeof(DXV.Group))]
 public Rectangle? Rectangle { get => _Rectangle; set => UpdateField(ref _Rectangle, value, nameof(Rectangle)); }

 private Rectangle? _Rectangle;
 [OpenXmlElement(typeof(DXV.Group))]
 public RoundRectangle? RoundRectangle { get => _RoundRectangle; set => UpdateField(ref _RoundRectangle, value, nameof(RoundRectangle)); }

 private RoundRectangle? _RoundRectangle;
 [OpenXmlElement(typeof(DXV.Group))]
 public Diagram? Diagram { get => _Diagram; set => UpdateField(ref _Diagram, value, nameof(Diagram)); }

 private Diagram? _Diagram;
 [OpenXmlElement(typeof(DXV.Group))]
 public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }

 private Lock? _Lock;
 [OpenXmlElement(typeof(DXV.Group))]
 public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }

 private ClipPath? _ClipPath;
 [OpenXmlElement(typeof(DXV.Group))]
 public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }

 private TextWrap? _TextWrap;
 [OpenXmlElement(typeof(DXV.Group))]
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

 private bool? _AnchorLock;
}