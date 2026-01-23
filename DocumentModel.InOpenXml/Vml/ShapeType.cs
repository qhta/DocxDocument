using DocumentFormat.OpenXml.EMMA;
using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
/// <summary>
/// Represents a shape template in a VML drawing, providing properties for styling, positioning, behavior, and embedded content.
/// This class enables advanced customization and management of VML shapes, including hyperlinks, CSS references, coordinate space, borders, fill, stroke, shadow, text, image data, and more.
/// </summary>
public partial class ShapeType : ModelElement<DXV.Shapetype>, IEmbeddedObjectContent
{
    /// <summary>
    /// Unique identifier for the shape template.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    /// Shape styling properties, specified as a CSS style string.
    /// </summary>
    public string? Style { get; set; }
    /// <summary>
    /// Hyperlink target for the shape.
    /// </summary>
    public string? Href { get; set; }
    /// <summary>
    /// Hyperlink display target for the shape.
    /// </summary>
    public string? Target { get; set; }
    /// <summary>
    /// CSS class reference for the shape.
    /// </summary>
    public string? Class { get; set; }
    /// <summary>
    /// Title of the shape, used for accessibility and tooltips.
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// Alternate text for the shape, used for accessibility.
    /// </summary>
    public string? Alternate { get; set; }
    /// <summary>
    /// Coordinate space size for the shape, specifying the width and height of the coordinate system.
    /// </summary>
    public string? CoordinateSize { get; set; }
    /// <summary>
    /// Coordinate space origin for the shape, specifying the starting point of the coordinate system.
    /// </summary>
    public string? CoordinateOrigin { get; set; }
    /// <summary>
    /// Shape bounding polygon coordinates for text wrapping.
    /// </summary>
    public string? WrapCoordinates { get; set; }
    /// <summary>
    /// Indicates whether the shape should be printed.
    /// </summary>
    public bool? Print { get; set; }
    /// <summary>
    /// Optional string for additional shape data.
    /// </summary>
    public string? OptionalString { get; set; }
    /// <summary>
    /// Indicates whether the shape handle is enabled.
    /// </summary>
    public bool? Oned { get; set; }
    /// <summary>
    /// Regroup ID for the shape, used for grouping shapes.
    /// </summary>
    public Int64? RegroupId { get; set; }
    /// <summary>
    /// Indicates whether double-click notification is enabled for the shape.
    /// </summary>
    public bool? DoubleClickNotify { get; set; }
    /// <summary>
    /// Indicates whether button behavior is enabled for the shape.
    /// </summary>
    public bool? Button { get; set; }
    /// <summary>
    /// Indicates whether script anchors are hidden for the shape.
    /// </summary>
    public bool? UserHidden { get; set; }
    /// <summary>
    /// Indicates whether the shape is a graphical bullet.
    /// </summary>
    public bool? Bullet { get; set; }
    /// <summary>
    /// Indicates whether the shape is a horizontal rule.
    /// </summary>
    public bool? Horizontal { get; set; }
    /// <summary>
    /// Indicates whether the horizontal rule is displayed in standard mode.
    /// </summary>
    public bool? HorizontalStandard { get; set; }
    /// <summary>
    /// Indicates whether 3D shading is applied to the horizontal rule.
    /// </summary>
    public bool? HorizontalNoShade { get; set; }
    /// <summary>
    /// Length percentage of the horizontal rule.
    /// </summary>
    public Single? HorizontalPercentage { get; set; }
    /// <summary>
    /// Alignment of the horizontal rule.
    /// </summary>
    public HorizontalRuleAlignmentKind? HorizontalAlignment { get; set; }
    /// <summary>
    /// Indicates whether the shape is allowed in a table cell.
    /// </summary>
    public bool? AllowInCell { get; set; }
    /// <summary>
    /// Indicates whether shape overlap is allowed.
    /// </summary>
    public bool? AllowOverlap { get; set; }
    /// <summary>
    /// Indicates whether the shape exists in the master slide.
    /// </summary>
    public bool? UserDrawn { get; set; }
    /// <summary>
    /// Top border color of the shape.
    /// </summary>
    public string? BorderTopColor { get; set; }
    /// <summary>
    /// Left border color of the shape.
    /// </summary>
    public string? BorderLeftColor { get; set; }
    /// <summary>
    /// Bottom border color of the shape.
    /// </summary>
    public string? BorderBottomColor { get; set; }
    /// <summary>
    /// Right border color of the shape.
    /// </summary>
    public string? BorderRightColor { get; set; }
    /// <summary>
    /// Diagram node layout identifier for the shape.
    /// </summary>
    public Int64? DiagramLayout { get; set; }
    /// <summary>
    /// Diagram node kind identifier for the shape.
    /// </summary>
    public Int64? DiagramNodeKind { get; set; }
    /// <summary>
    /// Diagram node recent layout identifier for the shape.
    /// </summary>
    public Int64? DiagramLayoutMostRecentUsed { get; set; }
    /// <summary>
    /// Text inset mode for the shape.
    /// </summary>
    public InsetMarginKind? InsetMode { get; set; }
    /// <summary>
    /// Indicates whether the shape is filled.
    /// </summary>
    public bool? Filled { get; set; }
    /// <summary>
    /// Fill color for the shape.
    /// </summary>
    public string? FillColor { get; set; }
    /// <summary>
    /// Indicates whether the shape is stroked.
    /// </summary>
    public bool? Stroked { get; set; }
    /// <summary>
    /// Stroke color for the shape.
    /// </summary>
    public string? StrokeColor { get; set; }
    /// <summary>
    /// Stroke weight for the shape.
    /// </summary>
    public string? StrokeWeight { get; set; }
    /// <summary>
    /// Indicates whether the border is inset from the path.
    /// </summary>
    public bool? InsetPen { get; set; }
    /// <summary>
    /// Optional number for additional shape data.
    /// </summary>
    public Int32? OptionalNumber { get; set; }
    /// <summary>
    /// Connector type for the shape.
    /// </summary>
    public ConnectorKind? ConnectorType { get; set; }
    /// <summary>
    /// Black-and-white mode for the shape.
    /// </summary>
    public BlackAndWhiteMode? BlackWhiteMode { get; set; }
    /// <summary>
    /// Pure black-and-white mode for the shape.
    /// </summary>
    public BlackAndWhiteMode? PureBlackWhiteMode { get; set; }
    /// <summary>
    /// Normal black-and-white mode for the shape.
    /// </summary>
    public BlackAndWhiteMode? NormalBlackWhiteMode { get; set; }
    /// <summary>
    /// Indicates whether a dashed outline is forced for the shape.
    /// </summary>
    public bool? ForceDash { get; set; }
    /// <summary>
    /// Indicates whether the shape is an embedded object icon.
    /// </summary>
    public bool? OleIcon { get; set; }
    /// <summary>
    /// Indicates whether the shape is an embedded object.
    /// </summary>
    public bool? Ole { get; set; }
    /// <summary>
    /// Indicates whether relative resize is preferred for the shape.
    /// </summary>
    public bool? PreferRelative { get; set; }
    /// <summary>
    /// Indicates whether the shape should be clipped to the wrapping polygon.
    /// </summary>
    public bool? ClipToWrap { get; set; }
    /// <summary>
    /// Indicates whether clipping is enabled for the shape.
    /// </summary>
    public bool? Clip { get; set; }
    /// <summary>
    /// Adjustment parameters for the shape.
    /// </summary>
    public string? Adjustment { get; set; }
    /// <summary>
    /// Edge path for the shape.
    /// </summary>
    public string? EdgePath { get; set; }
    /// <summary>
    /// Master element toggle for the shape.
    /// </summary>
    public string? Master { get; set; }
    /// <summary>
    /// Path element for the shape, specifying the geometry.
    /// </summary>
    public Path? Path { get; set; }
    /// <summary>
    /// Formulas element for the shape, specifying calculation formulas.
    /// </summary>
    public Formulas? Formulas { get; set; }
    /// <summary>
    /// Shape handles element for the shape, specifying interactive handles.
    /// </summary>
    public ShapeHandles? ShapeHandles { get; set; }
    /// <summary>
    /// Fill element for the shape, specifying fill formatting.
    /// </summary>
    public DMD.Fill? Fill { get; set; }
    /// <summary>
    /// Stroke element for the shape, specifying stroke formatting.
    /// </summary>
    public Stroke? Stroke { get; set; }
    /// <summary>
    /// Shadow element for the shape, specifying shadow formatting.
    /// </summary>
    public Shadow? Shadow { get; set; }
    /// <summary>
    /// Text box element for the shape, specifying text layout and formatting.
    /// </summary>
    public TextBox? TextBox { get; set; }
    /// <summary>
    /// Text path element for the shape, specifying text path formatting.
    /// </summary>
    public TextPath? TextPath { get; set; }
    /// <summary>
    /// Image data element for the shape, specifying embedded image content.
    /// </summary>
    public ImageData? ImageData { get; set; }
    /// <summary>
    /// Skew element for the shape, specifying skew transformation.
    /// </summary>
    public Skew? Skew { get; set; }
    /// <summary>
    /// Extrusion element for the shape, specifying 3D extrusion formatting.
    /// </summary>
    public Extrusion? Extrusion { get; set; }
    /// <summary>
    /// Callout element for the shape, specifying callout formatting.
    /// </summary>
    public Callout? Callout { get; set; }
    /// <summary>
    /// Lock element for the shape, specifying locking options.
    /// </summary>
    public Lock? Lock { get; set; }
    /// <summary>
    /// Clip path element for the shape, specifying a custom clipping path.
    /// </summary>
    public ClipPath? ClipPath { get; set; }
    /// <summary>
    /// Signature line element for the shape, specifying digital signature options.
    /// </summary>
    public SignatureLine? SignatureLine { get; set; }
    /// <summary>
    /// Text wrap element for the shape, specifying text wrapping options.
    /// </summary>
    public TextWrap? TextWrap { get; set; }
    /// <summary>
    /// Indicates whether the shape anchor is locked.
    /// </summary>
    public bool? AnchorLock { get; set; }
    /// <summary>
    /// Top border type for the shape.
    /// </summary>
    public BorderType? TopBorder { get; set; }
    /// <summary>
    /// Bottom border type for the shape.
    /// </summary>
    public BorderType? BottomBorder { get; set; }
    /// <summary>
    /// Left border type for the shape.
    /// </summary>
    public BorderType? LeftBorder { get; set; }
    /// <summary>
    /// Right border type for the shape.
    /// </summary>
    public BorderType? RightBorder { get; set; }
    /// <summary>
    /// Complex element for the shape, specifying advanced formatting or behavior.
    /// </summary>
    public Complex? Complex { get; set; }
}