namespace DocumentModel.Vml;

/// <summary>
/// Shape Definition.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public System.String? Href { get ; set; }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public System.String? Target { get ; set; }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public System.String? Class { get ; set; }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public System.String? Alternate { get ; set; }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public System.String? CoordinateSize { get ; set; }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public System.String? CoordinateOrigin { get ; set; }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public System.String? WrapCoordinates { get ; set; }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public System.Boolean? Print { get ; set; }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public System.String? OptionalString { get ; set; }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public System.Boolean? Oned { get ; set; }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public System.Int32? RegroupId { get ; set; }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public System.Boolean? DoubleClickNotify { get ; set; }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public System.Boolean? Button { get ; set; }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public System.Boolean? UserHidden { get ; set; }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public System.Boolean? Bullet { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public System.Boolean? Horizontal { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public System.Boolean? HorizontalStandard { get ; set; }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public System.Boolean? HorizontalNoShade { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public System.Single? HorizontalPercentage { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public DocumentModel.Vml.Office.HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public System.Boolean? AllowInCell { get ; set; }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public System.Boolean? AllowOverlap { get ; set; }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public System.Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public System.String? BorderTopColor { get ; set; }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public System.String? BorderLeftColor { get ; set; }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public System.String? BorderBottomColor { get ; set; }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public System.String? BorderRightColor { get ; set; }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public System.Int32? DiagramLayout { get ; set; }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public System.Int32? DiagramNodeKind { get ; set; }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public System.Int32? DiagramLayoutMostRecentUsed { get ; set; }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public DocumentModel.Vml.Office.InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public System.Boolean? Filled { get ; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public System.String? FillColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public System.Boolean? Stroked { get ; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public System.String? StrokeColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public System.String? StrokeWeight { get ; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public System.Boolean? InsetPen { get ; set; }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public System.Int32? OptionalNumber { get ; set; }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public DocumentModel.Vml.Office.ConnectorKind? ConnectorType { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.Office.BlackAndWhiteMode? NormalBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public System.Boolean? ForceDash { get ; set; }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public System.Boolean? OleIcon { get ; set; }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public System.Boolean? Ole { get ; set; }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public System.Boolean? PreferRelative { get ; set; }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public System.Boolean? ClipToWrap { get ; set; }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public System.Boolean? Clip { get ; set; }
  
  /// <summary>
  /// Shape Type Reference
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// Adjustment Parameters
  /// </summary>
  public System.String? Adjustment { get ; set; }
  
  /// <summary>
  /// Edge Path
  /// </summary>
  public System.String? EdgePath { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.IBase64BinaryValue? EncodedPackage { get ; set; }
  
  /// <summary>
  /// Storage for Alternate Math Content
  /// </summary>
  public System.String? EquationXml { get ; set; }
  
  public DocumentModel.Vml.IPath? Path { get ; set; }
  
  public DocumentModel.Vml.IFormulas? Formulas { get ; set; }
  
  public DocumentModel.Vml.IShapeHandles? ShapeHandles { get ; set; }
  
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
  public DocumentModel.Vml.IStroke? Stroke { get ; set; }
  
  public DocumentModel.Vml.IShadow? Shadow { get ; set; }
  
  public DocumentModel.Vml.ITextBox? TextBox { get ; set; }
  
  public DocumentModel.Vml.ITextPath? TextPath { get ; set; }
  
  public DocumentModel.Vml.IImageData? ImageData { get ; set; }
  
  public DocumentModel.Vml.Office.ISkew? Skew { get ; set; }
  
  public DocumentModel.Vml.Office.IExtrusion? Extrusion { get ; set; }
  
  public DocumentModel.Vml.Office.ICallout? Callout { get ; set; }
  
  public DocumentModel.Vml.Office.ILock? Lock { get ; set; }
  
  public DocumentModel.Vml.Office.IClipPath? ClipPath { get ; set; }
  
  public DocumentModel.Vml.Office.ISignatureLine? SignatureLine { get ; set; }
  
  public DocumentModel.Vml.Wordprocessing.ITextWrap? TextWrap { get ; set; }
  
  public System.Boolean? AnchorLock { get ; set; }
  
  public DocumentModel.Vml.Wordprocessing.IBorderType? TopBorder { get ; set; }
  
  public DocumentModel.Vml.Wordprocessing.IBorderType? BottomBorder { get ; set; }
  
  public DocumentModel.Vml.Wordprocessing.IBorderType? LeftBorder { get ; set; }
  
  public DocumentModel.Vml.Wordprocessing.IBorderType? RightBorder { get ; set; }
  
  public DocumentModel.Vml.Spreadsheet.IClientData? ClientData { get ; set; }
  
  public DocumentModel.Vml.Presentation.ITextData? TextData { get ; set; }
  
  public DocumentModel.Vml.Office.IInk? Ink { get ; set; }
  
  public System.Boolean? InkAnnotationFlag { get ; set; }
  
}
