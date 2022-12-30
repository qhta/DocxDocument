namespace DocumentModel.Vml;

/// <summary>
/// Rounded Rectangle.
/// </summary>
public partial class RoundRectangle
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public String? Style { get; set; }
  
  /// <summary>
  /// href
  /// </summary>
  public String? Href { get; set; }
  
  /// <summary>
  /// target
  /// </summary>
  public String? Target { get; set; }
  
  /// <summary>
  /// class
  /// </summary>
  public String? Class { get; set; }
  
  /// <summary>
  /// title
  /// </summary>
  public String? Title { get; set; }
  
  /// <summary>
  /// alt
  /// </summary>
  public String? Alternate { get; set; }
  
  /// <summary>
  /// coordsize
  /// </summary>
  public String? CoordinateSize { get; set; }
  
  /// <summary>
  /// wrapcoords
  /// </summary>
  public String? WrapCoordinates { get; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public Boolean? Print { get; set; }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public String? OptionalString { get; set; }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public Boolean? Oned { get; set; }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public Int32? RegroupId { get; set; }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public Boolean? DoubleClickNotify { get; set; }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public Boolean? Button { get; set; }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public Boolean? UserHidden { get; set; }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public Boolean? Bullet { get; set; }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public Boolean? Horizontal { get; set; }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public Boolean? HorizontalStandard { get; set; }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public Boolean? HorizontalNoShade { get; set; }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage { get; set; }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public DocumentModel.Vml.HorizontalRuleAlignmentKind? HorizontalAlignment { get; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell { get; set; }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public Boolean? AllowOverlap { get; set; }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public Boolean? UserDrawn { get; set; }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public String? BorderTopColor { get; set; }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public String? BorderLeftColor { get; set; }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public String? BorderBottomColor { get; set; }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public String? BorderRightColor { get; set; }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public Int32? DiagramLayout { get; set; }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public Int32? DiagramNodeKind { get; set; }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed { get; set; }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public DocumentModel.Vml.InsetMarginKind? InsetMode { get; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? Filled { get; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? FillColor { get; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? Stroked { get; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor { get; set; }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public String? StrokeWeight { get; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? InsetPen { get; set; }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public Int32? OptionalNumber { get; set; }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public DocumentModel.Vml.ConnectorKind? ConnectorType { get; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? BlackWhiteMode { get; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? PureBlackWhiteMode { get; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? NormalBlackWhiteMode { get; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash { get; set; }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public Boolean? OleIcon { get; set; }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public Boolean? Ole { get; set; }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public Boolean? PreferRelative { get; set; }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public Boolean? ClipToWrap { get; set; }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public Boolean? Clip { get; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.Base64Binary? Gfxdata { get; set; }
  
  /// <summary>
  /// Rounded Corner Arc Size
  /// </summary>
  public String? ArcSize { get; set; }
  
  public DocumentModel.Vml.Path? Path { get; set; }
  
  public DocumentModel.Vml.Formulas? Formulas { get; set; }
  
  public DocumentModel.Vml.ShapeHandles? ShapeHandles { get; set; }
  
  public DocumentModel.Vml.Fill? Fill { get; set; }
  
  public DocumentModel.Vml.Stroke? Stroke { get; set; }
  
  public DocumentModel.Vml.Shadow? Shadow { get; set; }
  
  public DocumentModel.Vml.TextBox? TextBox { get; set; }
  
  public DocumentModel.Vml.TextPath? TextPath { get; set; }
  
  public DocumentModel.Vml.ImageData? ImageData { get; set; }
  
  public DocumentModel.Vml.Skew? Skew { get; set; }
  
  public DocumentModel.Vml.Extrusion? Extrusion { get; set; }
  
  public DocumentModel.Vml.Callout? Callout { get; set; }
  
  public DocumentModel.Vml.Lock? Lock { get; set; }
  
  public DocumentModel.Vml.ClipPath? ClipPath { get; set; }
  
  public DocumentModel.Vml.SignatureLine? SignatureLine { get; set; }
  
  public DocumentModel.Wordprocessing.Vml.TextWrap? TextWrap { get; set; }
  
  public Boolean? AnchorLock { get; set; }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? TopBorder { get; set; }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? BottomBorder { get; set; }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? LeftBorder { get; set; }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? RightBorder { get; set; }
  
}
