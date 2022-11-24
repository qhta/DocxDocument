namespace DocumentModel.Vml;

/// <summary>
/// Line.
/// </summary>
public interface ILine // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public ITrueFalseValue? Print { get ; set; }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public String? OptionalString { get ; set; }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public ITrueFalseValue? Oned { get ; set; }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public Int32? RegroupId { get ; set; }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public ITrueFalseValue? DoubleClickNotify { get ; set; }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public ITrueFalseValue? Button { get ; set; }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public ITrueFalseValue? UserHidden { get ; set; }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public ITrueFalseValue? Bullet { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public ITrueFalseValue? Horizontal { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public ITrueFalseValue? HorizontalStandard { get ; set; }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public ITrueFalseValue? HorizontalNoShade { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public HorizontalRuleAlignmentValues? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public ITrueFalseValue? AllowInCell { get ; set; }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public ITrueFalseValue? AllowOverlap { get ; set; }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public ITrueFalseValue? UserDrawn { get ; set; }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public String? BorderTopColor { get ; set; }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public String? BorderLeftColor { get ; set; }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public String? BorderBottomColor { get ; set; }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public String? BorderRightColor { get ; set; }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public Int32? DiagramLayout { get ; set; }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public Int32? DiagramNodeKind { get ; set; }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed { get ; set; }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public InsetMarginValues? InsetMode { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? Filled { get ; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? FillColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public ITrueFalseValue? Stroked { get ; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public String? StrokeWeight { get ; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public ITrueFalseValue? InsetPen { get ; set; }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public Int32? OptionalNumber { get ; set; }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public ConnectorValues? ConnectorType { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? NormalBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public ITrueFalseValue? ForceDash { get ; set; }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public ITrueFalseValue? OleIcon { get ; set; }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public ITrueFalseBlankValue? Ole { get ; set; }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public ITrueFalseValue? PreferRelative { get ; set; }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public ITrueFalseValue? ClipToWrap { get ; set; }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public ITrueFalseValue? Clip { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public IBase64BinaryValue? Gfxdata { get ; set; }
  
  /// <summary>
  /// Line Start
  /// </summary>
  public String? From { get ; set; }
  
  /// <summary>
  /// Line End Point
  /// </summary>
  public String? To { get ; set; }
  
}
