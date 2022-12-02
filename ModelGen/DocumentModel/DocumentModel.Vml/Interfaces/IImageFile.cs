namespace DocumentModel.Vml;

/// <summary>
/// Image File.
/// </summary>
public interface IImageFile // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public String? Style { get ; set; }
  
  /// <summary>
  /// href
  /// </summary>
  public String? Href { get ; set; }
  
  /// <summary>
  /// target
  /// </summary>
  public String? Target { get ; set; }
  
  /// <summary>
  /// class
  /// </summary>
  public String? Class { get ; set; }
  
  /// <summary>
  /// title
  /// </summary>
  public String? Title { get ; set; }
  
  /// <summary>
  /// alt
  /// </summary>
  public String? Alternate { get ; set; }
  
  /// <summary>
  /// coordsize
  /// </summary>
  public String? CoordinateSize { get ; set; }
  
  /// <summary>
  /// wrapcoords
  /// </summary>
  public String? WrapCoordinates { get ; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public Boolean? Print { get ; set; }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public String? OptionalString { get ; set; }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public Boolean? Oned { get ; set; }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public Int32? RegroupId { get ; set; }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public Boolean? DoubleClickNotify { get ; set; }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public Boolean? Button { get ; set; }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public Boolean? UserHidden { get ; set; }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public Boolean? Bullet { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public Boolean? Horizontal { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public Boolean? HorizontalStandard { get ; set; }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public Boolean? HorizontalNoShade { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage { get ; set; }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell { get ; set; }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public Boolean? AllowOverlap { get ; set; }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public Boolean? UserDrawn { get ; set; }
  
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
  public InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? Filled { get ; set; }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? FillColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? Stroked { get ; set; }
  
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
  public Boolean? InsetPen { get ; set; }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public Int32? OptionalNumber { get ; set; }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public ConnectorKind? ConnectorType { get ; set; }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode { get ; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash { get ; set; }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public Boolean? OleIcon { get ; set; }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public Boolean? Ole { get ; set; }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public Boolean? PreferRelative { get ; set; }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public Boolean? ClipToWrap { get ; set; }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public Boolean? Clip { get ; set; }
  
  /// <summary>
  /// Image Source
  /// </summary>
  public String? Source { get ; set; }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  public String? CropLeft { get ; set; }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  public String? CropTop { get ; set; }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  public String? CropRight { get ; set; }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  public String? CropBottom { get ; set; }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  public String? Gain { get ; set; }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  public String? BlackLevel { get ; set; }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  public String? Gamma { get ; set; }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  public Boolean? GrayScale { get ; set; }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  public Boolean? BiLevel { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.IBase64BinaryValue? Gfxdata { get ; set; }
  
  public Collection<IPath>? Paths { get ; set; }
  
  public Collection<IFormulas>? Formulases { get ; set; }
  
  public Collection<IShapeHandles>? ShapeHandleses { get ; set; }
  
  public Collection<IFill>? Fills { get ; set; }
  
  public Collection<IStroke>? Strokes { get ; set; }
  
  public Collection<IShadow>? Shadows { get ; set; }
  
  public Collection<ITextBox>? TextBoxs { get ; set; }
  
  public Collection<ITextPath>? TextPaths { get ; set; }
  
  public Collection<IImageData>? ImageDatas { get ; set; }
  
  public Collection<ISkew>? Skews { get ; set; }
  
  public Collection<IExtrusion>? Extrusions { get ; set; }
  
  public Collection<ICallout>? Callouts { get ; set; }
  
  public Collection<ILock>? Locks { get ; set; }
  
  public Collection<IClipPath>? ClipPaths { get ; set; }
  
  public Collection<ISignatureLine>? SignatureLines { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Vml.ITextWrap>? TextWraps { get ; set; }
  
  public Collection<Boolean>? AnchorLocks { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Vml.IBorderType>? TopBorders { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Vml.IBorderType>? BottomBorders { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Vml.IBorderType>? LeftBorders { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Vml.IBorderType>? RightBorders { get ; set; }
  
  public Collection<DocumentModel.Spreadsheet.Vml.IClientData>? ClientDatas { get ; set; }
  
  public Collection<DocumentModel.Presentation.Vml.ITextData>? TextDatas { get ; set; }
  
}
