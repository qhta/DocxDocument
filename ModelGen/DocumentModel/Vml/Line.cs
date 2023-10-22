namespace DocumentModel.Vml;


/// <summary>
///   Line.
/// </summary>
public partial class Line
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
  public DM.TrueFalseValue? Print { get; set; }
  
  
  /// <summary>
  ///   Optional String
  /// </summary>
  public String? OptionalString { get; set; }
  
  
  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  public DM.TrueFalseValue? Oned { get; set; }
  
  
  /// <summary>
  ///   Regroup ID
  /// </summary>
  public Int64? RegroupId { get; set; }
  
  
  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  public DM.TrueFalseValue? DoubleClickNotify { get; set; }
  
  
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  public DM.TrueFalseValue? Button { get; set; }
  
  
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  public DM.TrueFalseValue? UserHidden { get; set; }
  
  
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  public DM.TrueFalseValue? Bullet { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  public DM.TrueFalseValue? Horizontal { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  public DM.TrueFalseValue? HorizontalStandard { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  public DM.TrueFalseValue? HorizontalNoShade { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage { get; set; }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public DM.TrueFalseValue? AllowInCell { get; set; }
  
  
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  public DM.TrueFalseValue? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  public DM.TrueFalseValue? UserDrawn { get; set; }
  
  
  /// <summary>
  ///   Border Top Color
  /// </summary>
  public String? BorderTopColor { get; set; }
  
  
  /// <summary>
  ///   Border Left Color
  /// </summary>
  public String? BorderLeftColor { get; set; }
  
  
  /// <summary>
  ///   Bottom Border Color
  /// </summary>
  public String? BorderBottomColor { get; set; }
  
  
  /// <summary>
  ///   Border Right Color
  /// </summary>
  public String? BorderRightColor { get; set; }
  
  
  /// <summary>
  ///   Diagram Node Layout Identifier
  /// </summary>
  public Int64? DiagramLayout { get; set; }
  
  
  /// <summary>
  ///   Diagram Node Identifier
  /// </summary>
  public Int64? DiagramNodeKind { get; set; }
  
  
  /// <summary>
  ///   Diagram Node Recent Layout Identifier
  /// </summary>
  public Int64? DiagramLayoutMostRecentUsed { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public DM.TrueFalseValue? Filled { get; set; }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  public String? FillColor { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public DM.TrueFalseValue? Stroked { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  public String? StrokeColor { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Weight
  /// </summary>
  public String? StrokeWeight { get; set; }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public DM.TrueFalseValue? InsetPen { get; set; }
  
  
  /// <summary>
  ///   Optional Number
  /// </summary>
  public Int32? OptionalNumber { get; set; }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public DM.TrueFalseValue? ForceDash { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  public DM.TrueFalseValue? OleIcon { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  public DM.TrueFalseBlankValue? Ole { get; set; }
  
  
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  public DM.TrueFalseValue? PreferRelative { get; set; }
  
  
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  public DM.TrueFalseValue? ClipToWrap { get; set; }
  
  
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  public DM.TrueFalseValue? Clip { get; set; }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  public DM.Base64Binary? Gfxdata { get; set; }
  
  
  /// <summary>
  ///   Line Start
  /// </summary>
  public String? From { get; set; }
  
  
  /// <summary>
  ///   Line End Point
  /// </summary>
  public String? To { get; set; }
  
}
