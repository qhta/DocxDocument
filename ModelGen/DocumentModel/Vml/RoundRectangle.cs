namespace DocumentModel.Vml;


/// <summary>
///   Rounded Rectangle.
/// </summary>
public partial class RoundRectangle
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   style
  /// </summary>
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   href
  /// </summary>
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   target
  /// </summary>
  public String? Target { get; set; }
  
  
  /// <summary>
  ///   class
  /// </summary>
  public String? Class { get; set; }
  
  
  /// <summary>
  ///   title
  /// </summary>
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   alt
  /// </summary>
  public String? Alternate { get; set; }
  
  
  /// <summary>
  ///   coordsize
  /// </summary>
  public String? CoordinateSize { get; set; }
  
  
  /// <summary>
  ///   wrapcoords
  /// </summary>
  public String? WrapCoordinates { get; set; }
  
  
  /// <summary>
  ///   print
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
  ///   Horizontal Rule Alignment
  /// </summary>
  public DocumentModel.Vml.Office.HorizontalRuleAlignmentKind? HorizontalAlignment { get; set; }
  
  
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
  ///   Text Inset Mode
  /// </summary>
  public DocumentModel.Vml.Office.InsetMarginKind? InsetMode { get; set; }
  
  
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
  ///   Shape Connector Type
  /// </summary>
  public DocumentModel.Vml.Office.ConnectorKind? ConnectorType { get; set; }
  
  
  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? BlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? PureBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? NormalBlackWhiteMode { get; set; }
  
  
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
  ///   Rounded Corner Arc Size
  /// </summary>
  public String? ArcSize { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
