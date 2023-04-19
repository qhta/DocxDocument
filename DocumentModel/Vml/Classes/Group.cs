using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;

namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Group.
/// </summary>
public class Group: ModelElement, IEmbeddedObjectContent
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public string? Style { get; set; }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public string? Href { get; set; }

  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  public string? Target { get; set; }

  /// <summary>
  ///   CSS Reference
  /// </summary>
  public string? Class { get; set; }

  /// <summary>
  ///   Shape Title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   Alternate Text
  /// </summary>
  public string? Alternate { get; set; }

  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  public string? CoordinateSize { get; set; }

  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  public string? CoordinateOrigin { get; set; }

  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  public string? WrapCoordinates { get; set; }

  /// <summary>
  ///   Print Toggle
  /// </summary>
  public bool? Print { get; set; }

  /// <summary>
  ///   spid
  /// </summary>
  public string? OptionalString { get; set; }

  /// <summary>
  ///   oned
  /// </summary>
  public bool? Oned { get; set; }

  /// <summary>
  ///   regroupid
  /// </summary>
  public Int64? RegroupId { get; set; }

  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  public bool? DoubleClickNotify { get; set; }

  /// <summary>
  ///   button
  /// </summary>
  public bool? Button { get; set; }

  /// <summary>
  ///   userhidden
  /// </summary>
  public bool? UserHidden { get; set; }

  /// <summary>
  ///   bullet
  /// </summary>
  public bool? Bullet { get; set; }

  /// <summary>
  ///   hr
  /// </summary>
  public bool? Horizontal { get; set; }

  /// <summary>
  ///   hrstd
  /// </summary>
  public bool? HorizontalStandard { get; set; }

  /// <summary>
  ///   hrnoshade
  /// </summary>
  public bool? HorizontalNoShade { get; set; }

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
  public bool? AllowInCell { get; set; }

  /// <summary>
  ///   allowoverlap
  /// </summary>
  public bool? AllowOverlap { get; set; }

  /// <summary>
  ///   userdrawn
  /// </summary>
  public bool? UserDrawn { get; set; }

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
  public string? TableProperties { get; set; }

  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  public string? TableLimits { get; set; }

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

  public bool? AnchorLock { get; set; }
}