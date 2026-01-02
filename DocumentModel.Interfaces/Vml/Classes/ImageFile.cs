using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;
using BorderType = DocumentModel.Wordprocessing.Vml.BorderType;
namespace DocumentModel.Vml;

/// <summary>
///   Image File.
/// </summary>
public class ImageFile: ModelElement, IEmbeddedObjectContent
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   style
  /// </summary>
  public string? Style { get; set; }
  /// <summary>
  ///   href
  /// </summary>
  public string? Href { get; set; }
  /// <summary>
  ///   target
  /// </summary>
  public string? Target { get; set; }
  /// <summary>
  ///   class
  /// </summary>
  public string? Class { get; set; }
  /// <summary>
  ///   title
  /// </summary>
  public string? Title { get; set; }
  /// <summary>
  ///   alt
  /// </summary>
  public string? Alternate { get; set; }
  /// <summary>
  ///   coordsize
  /// </summary>
  public string? CoordinateSize { get; set; }
  /// <summary>
  ///   wrapcoords
  /// </summary>
  public string? WrapCoordinates { get; set; }
  /// <summary>
  ///   print
  /// </summary>
  public bool? Print { get; set; }
  /// <summary>
  ///   Optional String
  /// </summary>
  public string? OptionalString { get; set; }
  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  public bool? Oned { get; set; }
  /// <summary>
  ///   Regroup ID
  /// </summary>
  public Int64? RegroupId { get; set; }
  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  public bool? DoubleClickNotify { get; set; }
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  public bool? Button { get; set; }
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  public bool? UserHidden { get; set; }
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  public bool? Bullet { get; set; }
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  public bool? Horizontal { get; set; }
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  public bool? HorizontalStandard { get; set; }
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  public bool? HorizontalNoShade { get; set; }
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
  public bool? AllowInCell { get; set; }
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  public bool? AllowOverlap { get; set; }
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  public bool? UserDrawn { get; set; }
  /// <summary>
  ///   Border Top Color
  /// </summary>
  public string? BorderTopColor { get; set; }
  /// <summary>
  ///   Border Left Color
  /// </summary>
  public string? BorderLeftColor { get; set; }
  /// <summary>
  ///   Bottom Border Color
  /// </summary>
  public string? BorderBottomColor { get; set; }
  /// <summary>
  ///   Border Right Color
  /// </summary>
  public string? BorderRightColor { get; set; }
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
  public bool? Filled { get; set; }
  /// <summary>
  ///   Fill Color
  /// </summary>
  public string? FillColor { get; set; }
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public bool? Stroked { get; set; }
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  public string? StrokeColor { get; set; }
  /// <summary>
  ///   Shape Stroke Weight
  /// </summary>
  public string? StrokeWeight { get; set; }
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public bool? InsetPen { get; set; }
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
  public bool? ForceDash { get; set; }
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  public bool? OleIcon { get; set; }
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  public bool? Ole { get; set; }
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  public bool? PreferRelative { get; set; }
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  public bool? ClipToWrap { get; set; }
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  public bool? Clip { get; set; }
  /// <summary>
  ///   Image Source
  /// </summary>
  public string? Source { get; set; }
  /// <summary>
  ///   Image Left Crop
  /// </summary>
  public string? CropLeft { get; set; }
  /// <summary>
  ///   Image Top Crop
  /// </summary>
  public string? CropTop { get; set; }
  /// <summary>
  ///   Image Right Crop
  /// </summary>
  public string? CropRight { get; set; }
  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  public string? CropBottom { get; set; }
  /// <summary>
  ///   Image Intensity
  /// </summary>
  public string? Gain { get; set; }
  /// <summary>
  ///   Image Brightness
  /// </summary>
  public string? BlackLevel { get; set; }
  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  public string? Gamma { get; set; }
  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  public Boolean GrayScale { get; set; }
  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  public bool? BiLevel { get; set; }
  /// <summary>
  ///   Encoded Package
  /// </summary>
  public IBase64Binary? Gfxdata { get; set; }
  public Path? Path { get; set; }
  public Formulas? Formulas { get; set; }
  public ShapeHandles? ShapeHandles { get; set; }
  public IFill? Fill { get; set; }
  public Stroke? Stroke { get; set; }
  public Shadow? Shadow { get; set; }
  public TextBox? TextBox { get; set; }
  public TextPath? TextPath { get; set; }
  public ImageData? ImageData { get; set; }
  public Skew? Skew { get; set; }
  public Extrusion? Extrusion { get; set; }
  public Callout? Callout { get; set; }
  public Lock? Lock { get; set; }
  public ClipPath? ClipPath { get; set; }
  public SignatureLine? SignatureLine { get; set; }
  public TextWrap? TextWrap { get; set; }
  public bool? AnchorLock { get; set; }
  public BorderType? TopBorder { get; set; }
  public BorderType? BottomBorder { get; set; }
  public BorderType? LeftBorder { get; set; }
  public BorderType? RightBorder { get; set; }
}