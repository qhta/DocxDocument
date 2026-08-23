using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;

/// <summary>
///   Shape Definition.
/// </summary>
[OpenXmlType(typeof(DXV.Shape))]
[DataContract]
[XmlRoot("Shape", Namespace = "DocumentModel.Vml")]
public partial class Shape: ModelElement<DXV.Shape>, IEmbeddedObjectContent
{
  /// <summary>
  ///   Unique identifier for the shape element.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   CSS-style formatting properties for the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Style))]
  public string? Style
  {
    get => _Style ??= GetProperty<string?>(GetUpdatableElement()?.Style);
    set => UpdateField(ref _Style, value, nameof(Style));
  }

  private string? _Style;

  /// <summary>
  ///   Target URL for hyperlink associated with the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Href))]
  public string? Href
  {
    get => _Href ??= GetProperty<string?>(GetUpdatableElement()?.Href);
    set => UpdateField(ref _Href, value, nameof(Href));
  }

  private string? _Href;

  /// <summary>
  ///   Target frame or window for hyperlink navigation.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Target))]
  public string? Target
  {
    get => _Target ??= GetProperty<string?>(GetUpdatableElement()?.Target);
    set => UpdateField(ref _Target, value, nameof(Target));
  }

  private string? _Target;

  /// <summary>
  ///   CSS class name for styling the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Class))]
  public string? Class
  {
    get => _Class ??= GetProperty<string?>(GetUpdatableElement()?.Class);
    set => UpdateField(ref _Class, value, nameof(Class));
  }

  private string? _Class;

  /// <summary>
  ///   Descriptive title for the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Title))]
  public string? Title
  {
    get => _Title ??= GetProperty<string?>(GetUpdatableElement()?.Title);
    set => UpdateField(ref _Title, value, nameof(Title));
  }

  private string? _Title;

  /// <summary>
  ///   Alternative text description for accessibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Alternate))]
  public string? Alternate
  {
    get => _Alternate ??= GetProperty<string?>(GetUpdatableElement()?.Alternate);
    set => UpdateField(ref _Alternate, value, nameof(Alternate));
  }

  private string? _Alternate;

  /// <summary>
  ///   Dimensions of the coordinate space for shape measurements.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.CoordinateSize))]
  public string? CoordinateSize
  {
    get => _CoordinateSize ??= GetProperty<string?>(GetUpdatableElement()?.CoordinateSize);
    set => UpdateField(ref _CoordinateSize, value, nameof(CoordinateSize));
  }

  private string? _CoordinateSize;

  /// <summary>
  ///   Origin point of the coordinate system for the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.CoordinateOrigin))]
  public string? CoordinateOrigin
  {
    get => _CoordinateOrigin ??= GetProperty<string?>(GetUpdatableElement()?.CoordinateOrigin);
    set => UpdateField(ref _CoordinateOrigin, value, nameof(CoordinateOrigin));
  }

  private string? _CoordinateOrigin;

  /// <summary>
  ///   Polygon coordinates defining the text wrapping boundary.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.WrapCoordinates))]
  public string? WrapCoordinates
  {
    get => _WrapCoordinates ??= GetProperty<string?>(GetUpdatableElement()?.WrapCoordinates);
    set => UpdateField(ref _WrapCoordinates, value, nameof(WrapCoordinates));
  }

  private string? _WrapCoordinates;

  /// <summary>
  ///   Indicates whether the shape should be printed.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Print))]
  public bool? Print
  {
    get => _Print ??= GetProperty<bool?>(GetUpdatableElement()?.Print);
    set => UpdateField(ref _Print, value, nameof(Print));
  }

  private bool? _Print;

  /// <summary>
  ///   Additional optional text associated with the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.OptionalString))]
  public string? OptionalString
  {
    get => _OptionalString ??= GetProperty<string?>(GetUpdatableElement()?.OptionalString);
    set => UpdateField(ref _OptionalString, value, nameof(OptionalString));
  }

  private string? _OptionalString;

  /// <summary>
  ///   Indicates whether the shape uses one-dimensional handles.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Oned))]
  public bool? Oned
  {
    get => _Oned ??= GetProperty<bool?>(GetUpdatableElement()?.Oned);
    set => UpdateField(ref _Oned, value, nameof(Oned));
  }

  private bool? _Oned;

  /// <summary>
  ///   Identifier for regrouping previously grouped shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.RegroupId))]
  public Int64? RegroupId
  {
    get => _RegroupId ??= GetProperty<Int64?>(GetUpdatableElement()?.RegroupId);
    set => UpdateField(ref _RegroupId, value, nameof(RegroupId));
  }

  private Int64? _RegroupId;

  /// <summary>
  ///   Indicates whether double-click events should be notified.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.DoubleClickNotify))]
  public bool? DoubleClickNotify
  {
    get => _DoubleClickNotify ??= GetProperty<bool?>(GetUpdatableElement()?.DoubleClickNotify);
    set => UpdateField(ref _DoubleClickNotify, value, nameof(DoubleClickNotify));
  }

  private bool? _DoubleClickNotify;

  /// <summary>
  ///   Indicates whether the shape behaves as a clickable button.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Button))]
  public bool? Button
  {
    get => _Button ??= GetProperty<bool?>(GetUpdatableElement()?.Button);
    set => UpdateField(ref _Button, value, nameof(Button));
  }

  private bool? _Button;

  /// <summary>
  ///   Indicates whether script anchor elements should be hidden.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.UserHidden))]
  public bool? UserHidden
  {
    get => _UserHidden ??= GetProperty<bool?>(GetUpdatableElement()?.UserHidden);
    set => UpdateField(ref _UserHidden, value, nameof(UserHidden));
  }

  private bool? _UserHidden;

  /// <summary>
  ///   Indicates whether the shape is used as a graphical bullet.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Bullet))]
  public bool? Bullet
  {
    get => _Bullet ??= GetProperty<bool?>(GetUpdatableElement()?.Bullet);
    set => UpdateField(ref _Bullet, value, nameof(Bullet));
  }

  private bool? _Bullet;

  /// <summary>
  ///   Indicates whether the shape represents a horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Horizontal))]
  public bool? Horizontal
  {
    get => _Horizontal ??= GetProperty<bool?>(GetUpdatableElement()?.Horizontal);
    set => UpdateField(ref _Horizontal, value, nameof(Horizontal));
  }

  private bool? _Horizontal;

  /// <summary>
  ///   Indicates whether the horizontal rule uses standard display mode.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.HorizontalStandard))]
  public bool? HorizontalStandard
  {
    get => _HorizontalStandard ??= GetProperty<bool?>(GetUpdatableElement()?.HorizontalStandard);
    set => UpdateField(ref _HorizontalStandard, value, nameof(HorizontalStandard));
  }

  private bool? _HorizontalStandard;

  /// <summary>
  ///   Indicates whether 3D shading is disabled for the horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.HorizontalNoShade))]
  public bool? HorizontalNoShade
  {
    get => _HorizontalNoShade ??= GetProperty<bool?>(GetUpdatableElement()?.HorizontalNoShade);
    set => UpdateField(ref _HorizontalNoShade, value, nameof(HorizontalNoShade));
  }

  private bool? _HorizontalNoShade;

  /// <summary>
  ///   Percentage of available width for the horizontal rule.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.HorizontalPercentage))]
  public Single? HorizontalPercentage
  {
    get => _HorizontalPercentage ??= GetProperty<Single?>(GetUpdatableElement()?.HorizontalPercentage);
    set => UpdateField(ref _HorizontalPercentage, value, nameof(HorizontalPercentage));
  }

  private Single? _HorizontalPercentage;

  /// <summary>
  ///   Alignment of the horizontal rule within its container.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.HorizontalAlignment))]
  public HorizontalRuleAlignment? HorizontalAlignment
  {
    get => _HorizontalAlignment ??= GetProperty<HorizontalRuleAlignment?>(GetUpdatableElement()?.HorizontalAlignment);
    set => UpdateField(ref _HorizontalAlignment, value, nameof(HorizontalAlignment));
  }

  private HorizontalRuleAlignment? _HorizontalAlignment;

  /// <summary>
  ///   Indicates whether the shape can be placed inside a table cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.AllowInCell))]
  public bool? AllowInCell
  {
    get => _AllowInCell ??= GetProperty<bool?>(GetUpdatableElement()?.AllowInCell);
    set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell));
  }

  private bool? _AllowInCell;

  /// <summary>
  ///   Indicates whether the shape can overlap other shapes.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.AllowOverlap))]
  public bool? AllowOverlap
  {
    get => _AllowOverlap ??= GetProperty<bool?>(GetUpdatableElement()?.AllowOverlap);
    set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap));
  }

  private bool? _AllowOverlap;

  /// <summary>
  ///   Indicates whether the shape was created by the user or exists in a master slide.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.UserDrawn))]
  public bool? UserDrawn
  {
    get => _UserDrawn ??= GetProperty<bool?>(GetUpdatableElement()?.UserDrawn);
    set => UpdateField(ref _UserDrawn, value, nameof(UserDrawn));
  }

  private bool? _UserDrawn;

  /// <summary>
  ///   Color value for the top border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.BorderTopColor))]
  public VmlColor? BorderTopColor
  {
    get => _BorderTopColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.BorderTopColor);
    set => UpdateField(ref _BorderTopColor, value, nameof(BorderTopColor));
  }

  private VmlColor? _BorderTopColor;

  /// <summary>
  ///   Color value for the left border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.BorderLeftColor))]
  public VmlColor? BorderLeftColor
  {
    get => _BorderLeftColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.BorderLeftColor);
    set => UpdateField(ref _BorderLeftColor, value, nameof(BorderLeftColor));
  }

  private VmlColor? _BorderLeftColor;

  /// <summary>
  ///   Color value for the bottom border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.BorderBottomColor))]
  public VmlColor? BorderBottomColor
  {
    get => _BorderBottomColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.BorderBottomColor);
    set => UpdateField(ref _BorderBottomColor, value, nameof(BorderBottomColor));
  }

  private VmlColor? _BorderBottomColor;

  /// <summary>
  ///   Color value for the right border of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.BorderRightColor))]
  public VmlColor? BorderRightColor
  {
    get => _BorderRightColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.BorderRightColor);
    set => UpdateField(ref _BorderRightColor, value, nameof(BorderRightColor));
  }

  private VmlColor? _BorderRightColor;

  /// <summary>
  ///   Identifier for the layout style of a diagram node.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.DiagramLayout))]
  public Int64? DiagramLayout
  {
    get => _DiagramLayout ??= GetProperty<Int64?>(GetUpdatableElement()?.DiagramLayout);
    set => UpdateField(ref _DiagramLayout, value, nameof(DiagramLayout));
  }

  private Int64? _DiagramLayout;

  /// <summary>
  ///   Unique identifier for a node within a diagram structure.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.DiagramNodeKind))]
  public Int64? DiagramNodeKind
  {
    get => _DiagramNodeKind ??= GetProperty<Int64?>(GetUpdatableElement()?.DiagramNodeKind);
    set => UpdateField(ref _DiagramNodeKind, value, nameof(DiagramNodeKind));
  }

  private Int64? _DiagramNodeKind;

  /// <summary>
  ///   Identifier for the most recently used layout for a diagram node.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.DiagramLayoutMostRecentUsed))]
  public Int64? DiagramLayoutMostRecentUsed
  {
    get => _DiagramLayoutMostRecentUsed ??= GetProperty<Int64?>(GetUpdatableElement()?.DiagramLayoutMostRecentUsed);
    set => UpdateField(ref _DiagramLayoutMostRecentUsed, value, nameof(DiagramLayoutMostRecentUsed));
  }

  private Int64? _DiagramLayoutMostRecentUsed;

  /// <summary>
  ///   Specifies how text margins are calculated within the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.InsetMode))]
  public InsetMargin? InsetMode
  {
    get => _InsetMode ??= GetProperty<InsetMargin?>(GetUpdatableElement()?.InsetMode);
    set => UpdateField(ref _InsetMode, value, nameof(InsetMode));
  }

  private InsetMargin? _InsetMode;

  /// <summary>
  ///   Indicates whether the shape interior is filled.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Filled))]
  public bool? Filled
  {
    get => _Filled ??= GetProperty<bool?>(GetUpdatableElement()?.Filled);
    set => UpdateField(ref _Filled, value, nameof(Filled));
  }

  private bool? _Filled;

  /// <summary>
  ///   Primary color used to fill the shape interior.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.FillColor))]
  public VmlColor? FillColor
  {
    get => _FillColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.FillColor);
    set => UpdateField(ref _FillColor, value, nameof(FillColor));
  }

  private VmlColor? _FillColor;

  /// <summary>
  ///   Indicates whether the shape outline is drawn.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Stroked))]
  public bool? Stroked
  {
    get => _Stroked ??= GetProperty<bool?>(GetUpdatableElement()?.Stroked);
    set => UpdateField(ref _Stroked, value, nameof(Stroked));
  }

  private bool? _Stroked;

  /// <summary>
  ///   Color used for the shape outline stroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.StrokeColor))]
  public VmlColor? StrokeColor
  {
    get => _StrokeColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.StrokeColor);
    set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor));
  }

  private VmlColor? _StrokeColor;

  /// <summary>
  ///   Width of the shape outline stroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.StrokeWeight))]
  public string? StrokeWeight
  {
    get => _StrokeWeight ??= GetProperty<string?>(GetUpdatableElement()?.StrokeWeight);
    set => UpdateField(ref _StrokeWeight, value, nameof(StrokeWeight));
  }

  private string? _StrokeWeight;

  /// <summary>
  ///   Indicates whether the border stroke is drawn inside the shape path.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.InsetPen))]
  public bool? InsetPen
  {
    get => _InsetPen ??= GetProperty<bool?>(GetUpdatableElement()?.InsetPen);
    set => UpdateField(ref _InsetPen, value, nameof(InsetPen));
  }

  private bool? _InsetPen;

  /// <summary>
  ///   Additional optional numeric value associated with the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.OptionalNumber))]
  public Int32? OptionalNumber
  {
    get => _OptionalNumber ??= GetProperty<Int32?>(GetUpdatableElement()?.OptionalNumber);
    set => UpdateField(ref _OptionalNumber, value, nameof(OptionalNumber));
  }

  private Int32? _OptionalNumber;

  /// <summary>
  ///   Type of connector line used when the shape acts as a connector.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.ConnectorType))]
  public ConnectorType? ConnectorType
  {
    get => _ConnectorType ??= GetProperty<ConnectorType?>(GetUpdatableElement()?.ConnectorType);
    set => UpdateField(ref _ConnectorType, value, nameof(ConnectorType));
  }

  private ConnectorType? _ConnectorType;

  /// <summary>
  ///   Rendering mode when displaying in black and white.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.BlackWhiteMode))]
  public BlackAndWhiteMode? BlackWhiteMode
  {
    get => _BlackWhiteMode ??= GetProperty<BlackAndWhiteMode?>(GetUpdatableElement()?.BlackWhiteMode);
    set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode));
  }

  private BlackAndWhiteMode? _BlackWhiteMode;

  /// <summary>
  ///   Rendering mode when displaying in pure black and white (no grayscale).
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.PureBlackWhiteMode))]
  public BlackAndWhiteMode? PureBlackWhiteMode
  {
    get => _PureBlackWhiteMode ??= GetProperty<BlackAndWhiteMode?>(GetUpdatableElement()?.PureBlackWhiteMode);
    set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode));
  }

  private BlackAndWhiteMode? _PureBlackWhiteMode;

  /// <summary>
  ///   Rendering mode when displaying in normal black and white with grayscale.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.NormalBlackWhiteMode))]
  public BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get => _NormalBlackWhiteMode ??= GetProperty<BlackAndWhiteMode?>(GetUpdatableElement()?.NormalBlackWhiteMode);
    set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode));
  }

  private BlackAndWhiteMode? _NormalBlackWhiteMode;

  /// <summary>
  ///   Indicates whether the outline stroke is forced to be dashed.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.ForceDash))]
  public bool? ForceDash
  {
    get => _ForceDash ??= GetProperty<bool?>(GetUpdatableElement()?.ForceDash);
    set => UpdateField(ref _ForceDash, value, nameof(ForceDash));
  }

  private bool? _ForceDash;

  /// <summary>
  ///   Indicates whether the embedded object is displayed as an icon.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.OleIcon))]
  public bool? OleIcon
  {
    get => _OleIcon ??= GetProperty<bool?>(GetUpdatableElement()?.OleIcon);
    set => UpdateField(ref _OleIcon, value, nameof(OleIcon));
  }

  private bool? _OleIcon;

  /// <summary>
  ///   Indicates whether the shape contains an embedded OLE object.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Ole))]
  public bool? Ole
  {
    get => _Ole ??= GetProperty<bool?>(GetUpdatableElement()?.Ole);
    set => UpdateField(ref _Ole, value, nameof(Ole));
  }

  private bool? _Ole;

  /// <summary>
  ///   Indicates whether the shape prefers relative resizing.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.PreferRelative))]
  public bool? PreferRelative
  {
    get => _PreferRelative ??= GetProperty<bool?>(GetUpdatableElement()?.PreferRelative);
    set => UpdateField(ref _PreferRelative, value, nameof(PreferRelative));
  }

  private bool? _PreferRelative;

  /// <summary>
  ///   Indicates whether the shape is clipped to the text wrapping polygon.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.ClipToWrap))]
  public bool? ClipToWrap
  {
    get => _ClipToWrap ??= GetProperty<bool?>(GetUpdatableElement()?.ClipToWrap);
    set => UpdateField(ref _ClipToWrap, value, nameof(ClipToWrap));
  }

  private bool? _ClipToWrap;

  /// <summary>
  ///   Indicates whether rendering of the shape is clipped to its boundaries.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Clip))]
  public bool? Clip
  {
    get => _Clip ??= GetProperty<bool?>(GetUpdatableElement()?.Clip);
    set => UpdateField(ref _Clip, value, nameof(Clip));
  }

  private bool? _Clip;

  /// <summary>
  ///   Reference to a predefined shape type definition.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Type))]
  public string? Type
  {
    get => _Type ??= GetProperty<string?>(GetUpdatableElement()?.Type);
    set => UpdateField(ref _Type, value, nameof(Type));
  }

  private string? _Type;

  /// <summary>
  ///   Values for adjustable parameters that modify the shape geometry.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.Adjustment))]
  public string? Adjustment
  {
    get => _Adjustment ??= GetProperty<string?>(GetUpdatableElement()?.Adjustment);
    set => UpdateField(ref _Adjustment, value, nameof(Adjustment));
  }

  private string? _Adjustment;

  /// <summary>
  ///   Path definition for the shape edge used in extrusion rendering.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.EdgePath))]
  public string? EdgePath
  {
    get => _EdgePath ??= GetProperty<string?>(GetUpdatableElement()?.EdgePath);
    set => UpdateField(ref _EdgePath, value, nameof(EdgePath));
  }

  private string? _EdgePath;

  /// <summary>
  ///   Base64-encoded binary package data embedded within the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.EncodedPackage))]
  public Base64Binary? EncodedPackage
  {
    get => _EncodedPackage ??= GetProperty<Base64Binary?>(GetUpdatableElement()?.EncodedPackage);
    set => UpdateField(ref _EncodedPackage, value, nameof(EncodedPackage));
  }

  private Base64Binary? _EncodedPackage;

  /// <summary>
  ///   XML representation of mathematical equation content as fallback.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shape.EquationXml))]
  public string? EquationXml
  {
    get => _EquationXml ??= GetProperty<string?>(GetUpdatableElement()?.EquationXml);
    set => UpdateField(ref _EquationXml, value, nameof(EquationXml));
  }

  private string? _EquationXml;

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
  public ShapeHandles? ShapeHandles
  {
    get => _ShapeHandles;
    set => UpdateField(ref _ShapeHandles, value, nameof(ShapeHandles));
  }

  private ShapeHandles? _ShapeHandles;

  /// <summary>
  ///   Provides drawing fill settings for the shape.
  /// </summary>
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;

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
  public SignatureLine? SignatureLine
  {
    get => _SignatureLine;
    set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine));
  }

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
  public Border? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

  private Border? _TopBorder;

  /// <summary>
  ///   Specifies the bottom border definition.
  /// </summary>
  public Border? BottomBorder
  {
    get => _BottomBorder;
    set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder));
  }

  private Border? _BottomBorder;

  /// <summary>
  ///   Specifies the left border definition.
  /// </summary>
  public Border? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

  private Border? _LeftBorder;

  /// <summary>
  ///   Specifies the right border definition.
  /// </summary>
  public Border? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

  private Border? _RightBorder;

  /// <summary>
  ///   Contains ink drawing data.
  /// </summary>
  public Ink? Ink { get => _Ink; set => UpdateField(ref _Ink, value, nameof(Ink)); }

  private Ink? _Ink;

  /// <summary>
  ///   Flags presence of ink annotations.
  /// </summary>
  public bool? InkAnnotationFlag
  {
    get => _InkAnnotationFlag;
    set => UpdateField(ref _InkAnnotationFlag, value, nameof(InkAnnotationFlag));
  }

  private bool? _InkAnnotationFlag;
}