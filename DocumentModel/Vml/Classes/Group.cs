using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Group.
/// </summary>
public class Group: ModelElement, IEmbeddedObjectElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public String? Style { get; set; }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public String? Href { get; set; }

  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  public String? Target { get; set; }

  /// <summary>
  ///   CSS Reference
  /// </summary>
  public String? Class { get; set; }

  /// <summary>
  ///   Shape Title
  /// </summary>
  public String? Title { get; set; }

  /// <summary>
  ///   Alternate Text
  /// </summary>
  public String? Alternate { get; set; }

  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  public String? CoordinateSize { get; set; }

  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  public String? CoordinateOrigin { get; set; }

  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  public String? WrapCoordinates { get; set; }

  /// <summary>
  ///   Print Toggle
  /// </summary>
  public Boolean? Print { get; set; }

  /// <summary>
  ///   spid
  /// </summary>
  public String? OptionalString { get; set; }

  /// <summary>
  ///   oned
  /// </summary>
  public Boolean? Oned { get; set; }

  /// <summary>
  ///   regroupid
  /// </summary>
  public Int64? RegroupId { get; set; }

  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  public Boolean? DoubleClickNotify { get; set; }

  /// <summary>
  ///   button
  /// </summary>
  public Boolean? Button { get; set; }

  /// <summary>
  ///   userhidden
  /// </summary>
  public Boolean? UserHidden { get; set; }

  /// <summary>
  ///   bullet
  /// </summary>
  public Boolean? Bullet { get; set; }

  /// <summary>
  ///   hr
  /// </summary>
  public Boolean? Horizontal { get; set; }

  /// <summary>
  ///   hrstd
  /// </summary>
  public Boolean? HorizontalStandard { get; set; }

  /// <summary>
  ///   hrnoshade
  /// </summary>
  public Boolean? HorizontalNoShade { get; set; }

  /// <summary>
  ///   hrpct
  /// </summary>
  public Single? HorizontalPercentage { get; set; }

  /// <summary>
  ///   hralign
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment { get; set; }

  /// <summary>
  ///   allowincell
  /// </summary>
  public Boolean? AllowInCell { get; set; }

  /// <summary>
  ///   allowoverlap
  /// </summary>
  public Boolean? AllowOverlap { get; set; }

  /// <summary>
  ///   userdrawn
  /// </summary>
  public Boolean? UserDrawn { get; set; }

  /// <summary>
  ///   dgmlayout
  /// </summary>
  public Int64? DiagramLayout { get; set; }

  /// <summary>
  ///   dgmnodekind
  /// </summary>
  public Int64? DiagramNodeKind { get; set; }

  /// <summary>
  ///   dgmlayoutmru
  /// </summary>
  public Int64? DiagramLayoutMostRecentUsed { get; set; }

  /// <summary>
  ///   insetmode
  /// </summary>
  public InsetMarginKind? InsetMode { get; set; }

  /// <summary>
  ///   Encoded Package
  /// </summary>
  public Base64Binary? Gfxdata { get; set; }

  /// <summary>
  ///   Group Diagram Type
  /// </summary>
  public EditAsKind? EditAs { get; set; }

  /// <summary>
  ///   Table Properties
  /// </summary>
  public String? TableProperties { get; set; }

  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  public String? TableLimits { get; set; }

  public Group? ChildGroup { get; set; }

  public Shape? Shape { get; set; }

  public Shapetype? Shapetype { get; set; }

  public Arc? Arc { get; set; }

  public Curve? Curve { get; set; }

  public ImageFile? ImageFile { get; set; }

  public Line? Line { get; set; }

  public Oval? Oval { get; set; }

  public PolyLine? PolyLine { get; set; }

  public Rectangle? Rectangle { get; set; }

  public RoundRectangle? RoundRectangle { get; set; }

  public Diagram? Diagram { get; set; }

  public Lock? Lock { get; set; }

  public ClipPath? ClipPath { get; set; }

  public TextWrap? TextWrap { get; set; }

  public Boolean? AnchorLock { get; set; }
}