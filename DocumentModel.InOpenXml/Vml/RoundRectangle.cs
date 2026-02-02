using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;

/// <summary>
///   Rounded Rectangle.
/// </summary>
[OpenXmlType(typeof(DXV.RoundRectangle))]
public partial class RoundRectangle: ModelElement<DXV.RoundRectangle>, IEmbeddedObjectContent
{
  /// <summary>
  ///   Unique identifier for the rounded rectangle element.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Id))]
  public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private string? _Id;

  /// <summary>
  ///   CSS-style formatting properties for the rounded rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Style))]
  public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

  private string? _Style;

  /// <summary>
  ///   Target URL for hyperlink associated with the rounded rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Href))]
  public string? Href { get => _Href; set => UpdateField(ref _Href, value, nameof(Href)); }

  private string? _Href;

  /// <summary>
  ///   Target frame or window for hyperlink navigation.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Target))]
  public string? Target { get => _Target; set => UpdateField(ref _Target, value, nameof(Target)); }

  private string? _Target;

  /// <summary>
  ///   CSS class name for styling the rounded rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Class))]
  public string? Class { get => _Class; set => UpdateField(ref _Class, value, nameof(Class)); }

  private string? _Class;

  /// <summary>
  ///   Descriptive title for the rounded rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Title))]
  public string? Title { get => _Title; set => UpdateField(ref _Title, value, nameof(Title)); }

  private string? _Title;

  /// <summary>
  ///   Alternative text description for accessibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Alternate))]
  public string? Alternate { get => _Alternate; set => UpdateField(ref _Alternate, value, nameof(Alternate)); }

  private string? _Alternate;

  /// <summary>
  ///   Dimensions of the coordinate space for shape measurements.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.CoordinateSize))]
  public string? CoordinateSize { get => _CoordinateSize; set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize)); }

  private string? _CoordinateSize;

  /// <summary>
  ///   Polygon coordinates defining the text wrapping boundary.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.WrapCoordinates))]
  public string? WrapCoordinates { get => _WrapCoordinates; set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates)); }

  private string? _WrapCoordinates;

  /// <summary>
  ///   Indicates whether the rounded rectangle should be printed.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Print))]
  public bool? Print { get => _Print; set => UpdateField(ref _Print, value, nameof(Print)); }

  private bool? _Print;

  /// <summary>
  ///   Additional optional text associated with the rounded rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.OptionalString))]
  public string? OptionalString { get => _OptionalString; set => UpdateField(ref _OptionalString, value, nameof(OptionalString)); }

  private string? _OptionalString;

  /// <summary>
  ///   Indicates whether the shape uses one-dimensional handles.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Oned))]
  public bool? Oned { get => _Oned; set => UpdateField(ref _Oned, value, nameof(Oned)); }

  private bool? _Oned;

  /// <summary>
  ///   Identifier for regrouping previously grouped shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.RegroupId))]
  public Int64? RegroupId { get => _RegroupId; set => UpdateField(ref _RegroupId, value, nameof(RegroupId)); }

  private Int64? _RegroupId;

  /// <summary>
  ///   Indicates whether double-click events should be notified.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.DoubleClickNotify))]
  public bool? DoubleClickNotify { get => _DoubleClickNotify; set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify)); }

  private bool? _DoubleClickNotify;

  /// <summary>
  ///   Indicates whether the shape behaves as a clickable button.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Button))]
  public bool? Button { get => _Button; set => UpdateField(ref _Button, value, nameof(Button)); }

  private bool? _Button;

  /// <summary>
  ///   Indicates whether script anchor elements should be hidden.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.UserHidden))]
  public bool? UserHidden { get => _UserHidden; set => UpdateField(ref _UserHidden, value, nameof(UserHidden)); }

  private bool? _UserHidden;

  /// <summary>
  ///   Indicates whether the shape is used as a graphical bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Bullet))]
  public bool? Bullet { get => _Bullet; set => UpdateField(ref _Bullet, value, nameof(Bullet)); }

  private bool? _Bullet;

  /// <summary>
  ///   Indicates whether the shape represents a horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Horizontal))]
  public bool? Horizontal { get => _Horizontal; set => UpdateField(ref _Horizontal, value, nameof(Horizontal)); }

  private bool? _Horizontal;

  /// <summary>
  ///   Indicates whether the horizontal rule uses standard display mode.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.HorizontalStandard))]
  public bool? HorizontalStandard { get => _HorizontalStandard; set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard)); }

  private bool? _HorizontalStandard;

  /// <summary>
  ///   Indicates whether 3D shading is disabled for the horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.HorizontalNoShade))]
  public bool? HorizontalNoShade { get => _HorizontalNoShade; set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade)); }

  private bool? _HorizontalNoShade;

  /// <summary>
  ///   Percentage of available width for the horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.HorizontalPercentage))]
  public Single? HorizontalPercentage { get => _HorizontalPercentage; set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage)); }

  private Single? _HorizontalPercentage;

  /// <summary>
  ///   Alignment of the horizontal rule within its container.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.HorizontalAlignment))]
  public HorizontalRuleAlignment? HorizontalAlignment { get => _HorizontalAlignment; set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment)); }

  private HorizontalRuleAlignment? _HorizontalAlignment;

  /// <summary>
  ///   Indicates whether the shape can be placed inside a table cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.AllowInCell))]
  public bool? AllowInCell { get => _AllowInCell; set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell)); }

  private bool? _AllowInCell;

  /// <summary>
  ///   Indicates whether the shape can overlap other shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.AllowOverlap))]
  public bool? AllowOverlap { get => _AllowOverlap; set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap)); }

  private bool? _AllowOverlap;

  /// <summary>
  ///   Indicates whether the shape was created by the user or exists in a master slide.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.UserDrawn))]
  public bool? UserDrawn { get => _UserDrawn; set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn)); }

  private bool? _UserDrawn;

  /// <summary>
  ///   Color value for the top border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.BorderTopColor))]
  public string? BorderTopColor { get => _BorderTopColor; set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor)); }

  private string? _BorderTopColor;

  /// <summary>
  ///   Color value for the left border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.BorderLeftColor))]
  public string? BorderLeftColor { get => _BorderLeftColor; set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor)); }

  private string? _BorderLeftColor;

  /// <summary>
  ///   Color value for the bottom border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.BorderBottomColor))]
  public string? BorderBottomColor { get => _BorderBottomColor; set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor)); }

  private string? _BorderBottomColor;

  /// <summary>
  ///   Color value for the right border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.BorderRightColor))]
  public string? BorderRightColor { get => _BorderRightColor; set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor)); }

  private string? _BorderRightColor;

  /// <summary>
  ///   Identifier for the layout style of a diagram node.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.DiagramLayout))]
  public Int64? DiagramLayout { get => _DiagramLayout; set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout)); }

  private Int64? _DiagramLayout;

  /// <summary>
  ///   Unique identifier for a node within a diagram structure.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.DiagramNodeKind))]
  public Int64? DiagramNodeKind { get => _DiagramNodeKind; set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind)); }

  private Int64? _DiagramNodeKind;

  /// <summary>
  ///   Identifier for the most recently used layout for a diagram node.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.DiagramLayoutMostRecentUsed))]
  public Int64? DiagramLayoutMostRecentUsed { get => _DiagramLayoutMostRecentUsed; set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed)); }

  private Int64? _DiagramLayoutMostRecentUsed;

  /// <summary>
  ///   Specifies how text margins are calculated within the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.InsetMode))]
  public InsetMargin? InsetMode { get => _InsetMode; set => UpdateField(ref _InsetMode, value, nameof(InsetMode)); }

  private InsetMargin? _InsetMode;

  /// <summary>
  ///   Indicates whether the shape interior is filled.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Filled))]
  public bool? Filled { get => _Filled; set => UpdateField(ref _Filled, value, nameof(Filled)); }

  private bool? _Filled;

  /// <summary>
  ///   Primary color used to fill the shape interior.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.FillColor))]
  public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

  private string? _FillColor;

  /// <summary>
  ///   Indicates whether the shape outline is drawn.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Stroked))]
  public bool? Stroked { get => _Stroked; set => UpdateField(ref _Stroked, value, nameof(Stroked)); }

  private bool? _Stroked;

  /// <summary>
  ///   Color used for the shape outline stroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.StrokeColor))]
  public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

  private string? _StrokeColor;

  /// <summary>
  ///   Width of the shape outline stroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.StrokeWeight))]
  public string? StrokeWeight { get => _StrokeWeight; set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight)); }

  private string? _StrokeWeight;

  /// <summary>
  ///   Indicates whether the border stroke is drawn inside the shape path.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.InsetPen))]
  public bool? InsetPen { get => _InsetPen; set => UpdateField(ref _InsetPen, value, nameof(InsetPen)); }

  private bool? _InsetPen;

  /// <summary>
  ///   Additional optional numeric value associated with the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.OptionalNumber))]
  public Int32? OptionalNumber { get => _OptionalNumber; set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber)); }

  private Int32? _OptionalNumber;

  /// <summary>
  ///   Type of connector line used when the shape acts as a connector.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.ConnectorType))]
  public ConnectorType? ConnectorType { get => _ConnectorType; set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType)); }

  private ConnectorType? _ConnectorType;

  /// <summary>
  ///   Rendering mode when displaying in black and white.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.BlackWhiteMode))]
  public BlackAndWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

  private BlackAndWhiteMode? _BlackWhiteMode;

  /// <summary>
  ///   Rendering mode when displaying in pure black and white (no grayscale).
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.PureBlackWhiteMode))]
  public BlackAndWhiteMode? PureBlackWhiteMode { get => _PureBlackWhiteMode; set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode)); }

  private BlackAndWhiteMode? _PureBlackWhiteMode;

  /// <summary>
  ///   Rendering mode when displaying in normal black and white with grayscale.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.NormalBlackWhiteMode))]
  public BlackAndWhiteMode? NormalBlackWhiteMode { get => _NormalBlackWhiteMode; set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode)); }

  private BlackAndWhiteMode? _NormalBlackWhiteMode;

  /// <summary>
  ///   Indicates whether the outline stroke is forced to be dashed.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.ForceDash))]
  public bool? ForceDash { get => _ForceDash; set => UpdateField(ref _ForceDash, value, nameof(ForceDash)); }

  private bool? _ForceDash;

  /// <summary>
  ///   Indicates whether the embedded object is displayed as an icon.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.OleIcon))]
  public bool? OleIcon { get => _OleIcon; set => UpdateField(ref _OleIcon, value, nameof(OleIcon)); }

  private bool? _OleIcon;

  /// <summary>
  ///   Indicates whether the shape contains an embedded OLE object.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Ole))]
  public bool? Ole { get => _Ole; set => UpdateField(ref _Ole, value, nameof(Ole)); }

  private bool? _Ole;

  /// <summary>
  ///   Indicates whether the shape prefers relative resizing.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.PreferRelative))]
  public bool? PreferRelative { get => _PreferRelative; set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative)); }

  private bool? _PreferRelative;

  /// <summary>
  ///   Indicates whether the shape is clipped to the text wrapping polygon.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.ClipToWrap))]
  public bool? ClipToWrap { get => _ClipToWrap; set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap)); }

  private bool? _ClipToWrap;

  /// <summary>
  ///   Indicates whether rendering of the shape is clipped to its boundaries.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Clip))]
  public bool? Clip { get => _Clip; set => UpdateField(ref _Clip, value, nameof(Clip)); }

  private bool? _Clip;

  /// <summary>
  ///   Base64-encoded binary package data embedded within the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.Gfxdata))]
  public Base64Binary? Gfxdata { get => _Gfxdata; set => UpdateField(ref _Gfxdata, value, nameof(Gfxdata)); }

  private Base64Binary? _Gfxdata;

  /// <summary>
  ///   Radius of the rounded corners as a percentage of the smaller dimension.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.RoundRectangle.ArcSize))]
  public string? ArcSize { get => _ArcSize; set => UpdateField(ref _ArcSize, value, nameof(ArcSize)); }

  private string? _ArcSize;

  /// <summary>
  ///   Defines the geometric path instructions.
  /// </summary>
  public Path? Path { get => _Path; set => UpdateField(ref _Path, value, nameof(Path)); }

  private Path? _Path;

  /// <summary>
  ///   Lists formula definitions used by the shape.
  /// </summary>
  public Formulas? Formulas { get => _Formulas; set => UpdateField(ref _Formulas, value, nameof(Formulas)); }

  private Formulas? _Formulas;

  /// <summary>
  ///   Specifies available handles for interactive editing.
  /// </summary>
  public ShapeHandles? ShapeHandles { get => _ShapeHandles; set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles)); }

  private ShapeHandles? _ShapeHandles;

  /// <summary>
  ///   Provides drawing fill settings for the shape.
  /// </summary>
  public DMD.Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private DMD.Fill? _Fill;

  /// <summary>
  ///   Describes stroke settings for the outline.
  /// </summary>
  public Stroke? Stroke { get => _Stroke; set => UpdateField(ref _Stroke, value, nameof(Stroke)); }

  private Stroke? _Stroke;

  /// <summary>
  ///   Contains drop shadow properties.
  /// </summary>
  public Shadow? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

  private Shadow? _Shadow;

  /// <summary>
  ///   Holds text box content and formatting.
  /// </summary>
  public TextBox? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

  private TextBox? _TextBox;

  /// <summary>
  ///   Defines decorative text path rendering.
  /// </summary>
  public TextPath? TextPath { get => _TextPath; set => UpdateField(ref _TextPath, value, nameof(TextPath)); }

  private TextPath? _TextPath;

  /// <summary>
  ///   References embedded image data.
  /// </summary>
  public ImageData? ImageData { get => _ImageData; set => UpdateField(ref _ImageData, value, nameof(ImageData)); }

  private ImageData? _ImageData;

  /// <summary>
  ///   Specifies skew transformation settings.
  /// </summary>
  public Skew? Skew { get => _Skew; set => UpdateField(ref _Skew, value, nameof(Skew)); }

  private Skew? _Skew;

  /// <summary>
  ///   Configures extrusion and 3D depth properties.
  /// </summary>
  public Extrusion? Extrusion { get => _Extrusion; set => UpdateField(ref _Extrusion, value, nameof(Extrusion)); }

  private Extrusion? _Extrusion;

  /// <summary>
  ///   Describes callout appearance and behavior.
  /// </summary>
  public Callout? Callout { get => _Callout; set => UpdateField(ref _Callout, value, nameof(Callout)); }

  private Callout? _Callout;

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
  ///   Represents signature line metadata.
  /// </summary>
  public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }

  private SignatureLine? _SignatureLine;

  /// <summary>
  ///   Defines text wrapping behavior.
  /// </summary>
  public TextWrap? TextWrap { get => _TextWrap; set => UpdateField(ref _TextWrap, value, nameof(TextWrap)); }

  private TextWrap? _TextWrap;

  /// <summary>
  ///   Indicates whether the shape anchor is locked.
  /// </summary>
  public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

  private bool? _AnchorLock;

  /// <summary>
  ///   Specifies the top border definition.
  /// </summary>
  public BorderType? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

  private BorderType? _TopBorder;

  /// <summary>
  ///   Specifies the bottom border definition.
  /// </summary>
  public BorderType? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }

  private BorderType? _BottomBorder;

  /// <summary>
  ///   Specifies the left border definition.
  /// </summary>
  public BorderType? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

  private BorderType? _LeftBorder;

  /// <summary>
  ///   Specifies the right border definition.
  /// </summary>
  public BorderType? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

  private BorderType? _RightBorder;
}