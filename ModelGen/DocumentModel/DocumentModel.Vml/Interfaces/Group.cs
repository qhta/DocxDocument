namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public interface Group
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public String? Style { get ; set; }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public String? Href { get ; set; }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public String? Target { get ; set; }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public String? Class { get ; set; }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public String? Title { get ; set; }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public String? Alternate { get ; set; }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public String? CoordinateSize { get ; set; }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public String? CoordinateOrigin { get ; set; }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public String? WrapCoordinates { get ; set; }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public Boolean? Print { get ; set; }
  
  /// <summary>
  /// spid
  /// </summary>
  public String? OptionalString { get ; set; }
  
  /// <summary>
  /// oned
  /// </summary>
  public Boolean? Oned { get ; set; }
  
  /// <summary>
  /// regroupid
  /// </summary>
  public Int32? RegroupId { get ; set; }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  public Boolean? DoubleClickNotify { get ; set; }
  
  /// <summary>
  /// button
  /// </summary>
  public Boolean? Button { get ; set; }
  
  /// <summary>
  /// userhidden
  /// </summary>
  public Boolean? UserHidden { get ; set; }
  
  /// <summary>
  /// bullet
  /// </summary>
  public Boolean? Bullet { get ; set; }
  
  /// <summary>
  /// hr
  /// </summary>
  public Boolean? Horizontal { get ; set; }
  
  /// <summary>
  /// hrstd
  /// </summary>
  public Boolean? HorizontalStandard { get ; set; }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  public Boolean? HorizontalNoShade { get ; set; }
  
  /// <summary>
  /// hrpct
  /// </summary>
  public Single? HorizontalPercentage { get ; set; }
  
  /// <summary>
  /// hralign
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// allowincell
  /// </summary>
  public Boolean? AllowInCell { get ; set; }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public Boolean? AllowOverlap { get ; set; }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  public Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  public Int32? DiagramLayout { get ; set; }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  public Int32? DiagramNodeKind { get ; set; }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed { get ; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.Base64BinaryValue? Gfxdata { get ; set; }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  public String? TableProperties { get ; set; }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  public String? TableLimits { get ; set; }
  
  public Collection<Group>? Groups { get ; set; }
  
  public Collection<Shape>? Shapes { get ; set; }
  
  public Collection<Shapetype>? Shapetypes { get ; set; }
  
  public Collection<Arc>? Arcs { get ; set; }
  
  public Collection<Curve>? Curves { get ; set; }
  
  public Collection<ImageFile>? ImageFiles { get ; set; }
  
  public Collection<Line>? Lines { get ; set; }
  
  public Collection<Oval>? Ovals { get ; set; }
  
  public Collection<PolyLine>? PolyLines { get ; set; }
  
  public Collection<Rectangle>? Rectangles { get ; set; }
  
  public Collection<RoundRectangle>? RoundRectangles { get ; set; }
  
  public Collection<Diagram>? Diagrams { get ; set; }
  
  public Collection<Lock>? Locks { get ; set; }
  
  public Collection<ClipPath>? ClipPaths { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Vml.TextWrap>? TextWraps { get ; set; }
  
  public Collection<Boolean>? AnchorLocks { get ; set; }
  
}
