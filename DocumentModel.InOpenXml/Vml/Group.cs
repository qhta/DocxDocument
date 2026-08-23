using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
///   Shape Group.
/// </summary>
[OpenXmlType(typeof(DXV.Group))]
[DataContract]
[XmlRoot("Group", Namespace = "DocumentModel.Vml")]
public partial class Group : ModelElementCollection<ModelElement, DXV.Group, DX.OpenXmlElement>, IEmbeddedObjectContent
{
  /// <summary>
  ///   Unique identifier for the group element.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Id))]
  public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private string? _Id;

  /// <summary>
  ///   CSS-style formatting properties for the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Style))]
  public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }
  private string? _Style;

  /// <summary>
  ///   Target URL for hyperlink associated with the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Href))]
  public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }
  private string? _Href;

  /// <summary>
  ///   Target frame or window for hyperlink navigation.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Target))]
  public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }
  private string? _Target;

  /// <summary>
  ///   CSS class name for styling the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Class))]
  public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }
  private string? _Class;

  /// <summary>
  ///   Descriptive title for the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Title))]
  public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }
  private string? _Title;

  /// <summary>
  ///   Alternative text description for accessibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Alternate))]
  public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }
  private string? _Alternate;

  /// <summary>
  ///   Dimensions of the coordinate space for shape measurements.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.CoordinateSize))]
  public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }
  private string? _CoordinateSize;

  /// <summary>
  ///   Origin point of the coordinate system for the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.CoordinateOrigin))]
  public string? CoordinateOrigin { get => _CoordinateOrigin; set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin)); }
  private string? _CoordinateOrigin;

  /// <summary>
  ///   Polygon coordinates defining the text wrapping boundary.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.WrapCoordinates))]
  public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }
  private string? _WrapCoordinates;

  /// <summary>
  ///   Indicates whether the group should be printed.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Print))]
  public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }
  private bool? _Print;

  /// <summary>
  ///   Optional string for additional group data.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.OptionalString))]
  public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }
  private string? _OptionalString;

  /// <summary>
  ///   Indicates whether the group uses one-dimensional handles.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Oned))]
  public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }
  private bool? _Oned;

  /// <summary>
  ///   Identifier for regrouping previously grouped shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.RegroupId))]
  public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }
  private Int64? _RegroupId;

  /// <summary>
  ///   Indicates whether double-click events should be notified.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.DoubleClickNotify))]
  public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }
  private bool? _DoubleClickNotify;

  /// <summary>
  ///   Indicates whether the group behaves as a clickable button.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Button))]
  public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }
  private bool? _Button;

  /// <summary>
  ///   Indicates whether script anchor elements should be hidden.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.UserHidden))]
  public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }
  private bool? _UserHidden;

  /// <summary>
  ///   Indicates whether the group is used as a graphical bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Bullet))]
  public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }
  private bool? _Bullet;

  /// <summary>
  ///   Indicates whether the group represents a horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Horizontal))]
  public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }
  private bool? _Horizontal;

  /// <summary>
  ///   Indicates whether the horizontal rule uses standard display mode.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.HorizontalStandard))]
  public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }
  private bool? _HorizontalStandard;

  /// <summary>
  ///   Indicates whether 3D shading is disabled for the horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.HorizontalNoShade))]
  public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }
  private bool? _HorizontalNoShade;

  /// <summary>
  ///   Percentage of available width for the horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.HorizontalPercentage))]
  public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }
  private Single? _HorizontalPercentage;

  /// <summary>
  ///   Alignment of the horizontal rule within its container.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.HorizontalAlignment))]
  public HorizontalRuleAlignment? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }
  private HorizontalRuleAlignment? _HorizontalAlignment;

  /// <summary>
  ///   Indicates whether the group can be placed inside a table cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.AllowInCell))]
  public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }
  private bool? _AllowInCell;

  /// <summary>
  ///   Indicates whether the group can overlap other shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.AllowOverlap))]
  public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }
  private bool? _AllowOverlap;

  /// <summary>
  ///   Indicates whether the group was created by the user or exists in a master slide.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.UserDrawn))]
  public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }
  private bool? _UserDrawn;

  /// <summary>
  ///   Identifier for the layout style of a diagram node.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.DiagramLayout))]
  public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }
  private Int64? _DiagramLayout;

  /// <summary>
  ///   Unique identifier for a node within a diagram structure.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.DiagramNodeKind))]
  public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }
  private Int64? _DiagramNodeKind;

  /// <summary>
  ///   Identifier for the most recently used layout for a diagram node.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.DiagramLayoutMostRecentUsed))]
  public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }
  private Int64? _DiagramLayoutMostRecentUsed;

  /// <summary>
  ///   Specifies how text margins are calculated within the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.InsetMode))]
  public InsetMargin? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }
  private InsetMargin? _InsetMode;

  /// <summary>
  ///   Base64-encoded binary package data embedded within the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.Gfxdata))]
  public Base64Binary? GfxData { get => _GfxData; set => UpdateField(ref _GfxData, value, nameof(GfxData)); }
  private Base64Binary? _GfxData;

  /// <summary>
  ///   Specifies the group diagram type for editing.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.EditAs))]
  public EditAs? EditAs { get => _EditAs; set => UpdateField(ref _EditAs, value, nameof(EditAs)); }
  private EditAs? _EditAs;

  /// <summary>
  ///   Table property settings for the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.TableProperties))]
  public string? TableProperties { get => _TableProperties; set => UpdateField(ref _TableProperties, value, nameof(TableProperties)); }
  private string? _TableProperties;

  /// <summary>
  ///   Table row height limits for the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Group.TableLimits))]
  public string? TableLimits { get => _TableLimits; set => UpdateField(ref _TableLimits, value, nameof(TableLimits)); }
  private string? _TableLimits;

  /// <summary>
  ///   Nested group element within this group.
  /// </summary>
  public Group? ChildGroup { get => _ChildGroup; set => UpdateField(ref _ChildGroup, value, nameof(ChildGroup)); }
  private Group? _ChildGroup;

  /// <summary>
  ///   Shape element contained in the group.
  /// </summary>
  public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }
  private Shape? _Shape;

  /// <summary>
  ///   Shape type definition for the group.
  /// </summary>
  public ShapeType? ShapeType { get => _ShapeType; set => UpdateField(ref _ShapeType, value, nameof(ShapeType)); }
  private ShapeType? _ShapeType;

  /// <summary>
  ///   Arc element contained in the group.
  /// </summary>
  public Arc? Arc { get => _Arc; set => UpdateField(ref _Arc, value, nameof(Arc)); }
  private Arc? _Arc;

  /// <summary>
  ///   Curve element contained in the group.
  /// </summary>
  public Curve? Curve { get => _Curve; set => UpdateField(ref _Curve, value, nameof(Curve)); }
  private Curve? _Curve;

  /// <summary>
  ///   Image file element contained in the group.
  /// </summary>
  public ImageFile? ImageFile { get => _ImageFile; set => UpdateField(ref _ImageFile, value, nameof(ImageFile)); }
  private ImageFile? _ImageFile;

  /// <summary>
  ///   Line element contained in the group.
  /// </summary>
  public Line? Line { get => _Line; set => UpdateField(ref _Line, value, nameof(Line)); }
  private Line? _Line;

  /// <summary>
  ///   Oval element contained in the group.
  /// </summary>
  public Oval? Oval { get => _Oval; set => UpdateField(ref _Oval, value, nameof(Oval)); }
  private Oval? _Oval;

  /// <summary>
  ///   Polyline element contained in the group.
  /// </summary>
  public PolyLine? PolyLine { get => _PolyLine; set => UpdateField(ref _PolyLine, value, nameof(PolyLine)); }
  private PolyLine? _PolyLine;

  /// <summary>
  ///   Rectangle element contained in the group.
  /// </summary>
  public Rectangle? Rectangle { get => _Rectangle; set => UpdateField(ref _Rectangle, value, nameof(Rectangle)); }
  private Rectangle? _Rectangle;

  /// <summary>
  ///   Rounded rectangle element contained in the group.
  /// </summary>
  public RoundRectangle? RoundRectangle { get => _RoundRectangle; set => UpdateField(ref _RoundRectangle, value, nameof(RoundRectangle)); }
  private RoundRectangle? _RoundRectangle;

  /// <summary>
  ///   Diagram element contained in the group.
  /// </summary>
  public Diagram? Diagram { get => _Diagram; set => UpdateField(ref _Diagram, value, nameof(Diagram)); }
  private Diagram? _Diagram;

  /// <summary>
  ///   Contains locking flags that restrict editing.
  /// </summary>
  public Lock? Lock { get => _Lock; set => UpdateField(ref _Lock, value, nameof(Lock)); }
  private Lock? _Lock;

  /// <summary>
  ///   Stores clipping path geometry.
  /// </summary>
  public ClipPath? ClipPath { get => _ClipPath; set => UpdateField(ref _ClipPath, value, nameof(ClipPath)); }
  private ClipPath? _ClipPath;

  /// <summary>
  ///   Defines text wrapping behavior.
  /// </summary>
  public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }
  private TextWrap? _TextWrap;

  /// <summary>
  ///   Indicates whether the group anchor is locked.
  /// </summary>
  public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }
  private bool? _AnchorLock;
}