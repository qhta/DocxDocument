namespace DocumentModel.Vml;

/// <summary>
/// Image File.
/// </summary>
public interface IImageFile // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// href
  /// </summary>
  public System.String? Href { get ; set; }
  
  /// <summary>
  /// target
  /// </summary>
  public System.String? Target { get ; set; }
  
  /// <summary>
  /// class
  /// </summary>
  public System.String? Class { get ; set; }
  
  /// <summary>
  /// title
  /// </summary>
  public System.String? Title { get ; set; }
  
  /// <summary>
  /// alt
  /// </summary>
  public System.String? Alternate { get ; set; }
  
  /// <summary>
  /// coordsize
  /// </summary>
  public System.String? CoordinateSize { get ; set; }
  
  /// <summary>
  /// wrapcoords
  /// </summary>
  public System.String? WrapCoordinates { get ; set; }
  
  /// <summary>
  /// print
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
  public DocumentModel.Vml.HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
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
  public DocumentModel.Vml.InsetMarginKind? InsetMode { get ; set; }
  
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
  public DocumentModel.Vml.ConnectorKind? ConnectorType { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? NormalBlackWhiteMode { get ; set; }
  
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
  /// Image Source
  /// </summary>
  public System.String? Source { get ; set; }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  public System.String? CropLeft { get ; set; }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  public System.String? CropTop { get ; set; }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  public System.String? CropRight { get ; set; }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  public System.String? CropBottom { get ; set; }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  public System.String? Gain { get ; set; }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  public System.String? BlackLevel { get ; set; }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  public System.String? Gamma { get ; set; }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  public System.Boolean? GrayScale { get ; set; }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  public System.Boolean? BiLevel { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.IBase64BinaryValue? Gfxdata { get ; set; }
  
  public DocumentModel.Vml.IPath? Path { get ; set; }
  
  public DocumentModel.Vml.IFormulas? Formulas { get ; set; }
  
  public DocumentModel.Vml.IShapeHandles? ShapeHandles { get ; set; }
  
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
  public DocumentModel.Vml.IStroke? Stroke { get ; set; }
  
  public DocumentModel.Vml.IShadow? Shadow { get ; set; }
  
  public DocumentModel.Vml.ITextBox? TextBox { get ; set; }
  
  public DocumentModel.Vml.ITextPath? TextPath { get ; set; }
  
  public DocumentModel.Vml.IImageData? ImageData { get ; set; }
  
  public DocumentModel.Vml.ISkew? Skew { get ; set; }
  
  public DocumentModel.Vml.IExtrusion? Extrusion { get ; set; }
  
  public DocumentModel.Vml.ICallout? Callout { get ; set; }
  
  public DocumentModel.Vml.ILock? Lock { get ; set; }
  
  public DocumentModel.Vml.IClipPath? ClipPath { get ; set; }
  
  public DocumentModel.Vml.ISignatureLine? SignatureLine { get ; set; }
  
  public DocumentModel.Wordprocessing.Vml.ITextWrap? TextWrap { get ; set; }
  
  public System.Boolean? AnchorLock { get ; set; }
  
  public DocumentModel.Wordprocessing.Vml.IBorderType? TopBorder { get ; set; }
  
  public DocumentModel.Wordprocessing.Vml.IBorderType? BottomBorder { get ; set; }
  
  public DocumentModel.Wordprocessing.Vml.IBorderType? LeftBorder { get ; set; }
  
  public DocumentModel.Wordprocessing.Vml.IBorderType? RightBorder { get ; set; }
  
  public DocumentModel.Spreadsheet.Vml.IClientData? ClientData { get ; set; }
  
  public DocumentModel.Presentation.Vml.ITextData? TextData { get ; set; }
  
}
