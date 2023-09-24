namespace DocumentModel.Vml;


/// <summary>
///   Shape Definition.
/// </summary>
public partial class Shape
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public HexInt? Id { get; set; }
  
  
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
  ///   Optional String
  /// </summary>
  public String? OptionalString { get; set; }
  
  
  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  public Boolean? Oned { get; set; }
  
  
  /// <summary>
  ///   Regroup ID
  /// </summary>
  public HexInt? RegroupId { get; set; }
  
  
  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  public Boolean? DoubleClickNotify { get; set; }
  
  
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  public Boolean? Button { get; set; }
  
  
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  public Boolean? UserHidden { get; set; }
  
  
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  public Boolean? Bullet { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  public Boolean? Horizontal { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  public Boolean? HorizontalStandard { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  public Boolean? HorizontalNoShade { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Alignment
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment { get; set; }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell { get; set; }
  
  
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  public Boolean? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  public Boolean? UserDrawn { get; set; }
  
  
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
  ///   Text Inset Mode
  /// </summary>
  public InsetMarginKind? InsetMode { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public Boolean? Filled { get; set; }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  public String? FillColor { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public Boolean? Stroked { get; set; }
  
  
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
  public Boolean? InsetPen { get; set; }
  
  
  /// <summary>
  ///   Optional Number
  /// </summary>
  public Int32? OptionalNumber { get; set; }
  
  
  /// <summary>
  ///   Shape Connector Type
  /// </summary>
  public ConnectorKind? ConnectorType { get; set; }
  
  
  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  public Boolean? OleIcon { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  public Boolean? Ole { get; set; }
  
  
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  public Boolean? PreferRelative { get; set; }
  
  
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  public Boolean? ClipToWrap { get; set; }
  
  
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  public Boolean? Clip { get; set; }
  
  
  /// <summary>
  ///   Shape Type Reference
  /// </summary>
  public String? Type { get; set; }
  
  
  /// <summary>
  ///   Adjustment Parameters
  /// </summary>
  public String? Adjustment { get; set; }
  
  
  /// <summary>
  ///   Edge Path
  /// </summary>
  public String? EdgePath { get; set; }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  public Base64Binary? EncodedPackage { get; set; }
  
  
  /// <summary>
  ///   Storage for Alternate Math Content
  /// </summary>
  public String? EquationXml { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
