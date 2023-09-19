namespace DocumentModel.Vml;


/// <summary>
///   Image File.
/// </summary>
public partial class ImageFile
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   style
  /// </summary>
  [SchemaAttr("style")]
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   href
  /// </summary>
  [SchemaAttr("href")]
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   target
  /// </summary>
  [SchemaAttr("target")]
  public String? Target { get; set; }
  
  
  /// <summary>
  ///   class
  /// </summary>
  [SchemaAttr("class")]
  public String? Class { get; set; }
  
  
  /// <summary>
  ///   title
  /// </summary>
  [SchemaAttr("title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   alt
  /// </summary>
  [SchemaAttr("alt")]
  public String? Alternate { get; set; }
  
  
  /// <summary>
  ///   coordsize
  /// </summary>
  [SchemaAttr("coordsize")]
  public String? CoordinateSize { get; set; }
  
  
  /// <summary>
  ///   wrapcoords
  /// </summary>
  [SchemaAttr("wrapcoords")]
  public String? WrapCoordinates { get; set; }
  
  
  /// <summary>
  ///   print
  /// </summary>
  [SchemaAttr("print")]
  public Boolean? Print { get; set; }
  
  
  /// <summary>
  ///   Optional String
  /// </summary>
  [SchemaAttr("o:spid")]
  public String? OptionalString { get; set; }
  
  
  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  [SchemaAttr("o:oned")]
  public Boolean? Oned { get; set; }
  
  
  /// <summary>
  ///   Regroup ID
  /// </summary>
  [SchemaAttr("o:regroupid")]
  public Int64? RegroupId { get; set; }
  
  
  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  [SchemaAttr("o:doubleclicknotify")]
  public Boolean? DoubleClickNotify { get; set; }
  
  
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  [SchemaAttr("o:button")]
  public Boolean? Button { get; set; }
  
  
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  [SchemaAttr("o:userhidden")]
  public Boolean? UserHidden { get; set; }
  
  
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  [SchemaAttr("o:bullet")]
  public Boolean? Bullet { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  [SchemaAttr("o:hr")]
  public Boolean? Horizontal { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  [SchemaAttr("o:hrstd")]
  public Boolean? HorizontalStandard { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  [SchemaAttr("o:hrnoshade")]
  public Boolean? HorizontalNoShade { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Length Percentage
  /// </summary>
  [SchemaAttr("o:hrpct")]
  public Single? HorizontalPercentage { get; set; }
  
  
  /// <summary>
  ///   Horizontal Rule Alignment
  /// </summary>
  [SchemaAttr("o:hralign")]
  public DocumentModel.Vml.Office.HorizontalRuleAlignmentValues? HorizontalAlignment { get; set; }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  [SchemaAttr("o:allowincell")]
  public Boolean? AllowInCell { get; set; }
  
  
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  [SchemaAttr("o:allowoverlap")]
  public Boolean? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  [SchemaAttr("o:userdrawn")]
  public Boolean? UserDrawn { get; set; }
  
  
  /// <summary>
  ///   Border Top Color
  /// </summary>
  [SchemaAttr("o:bordertopcolor")]
  public String? BorderTopColor { get; set; }
  
  
  /// <summary>
  ///   Border Left Color
  /// </summary>
  [SchemaAttr("o:borderleftcolor")]
  public String? BorderLeftColor { get; set; }
  
  
  /// <summary>
  ///   Bottom Border Color
  /// </summary>
  [SchemaAttr("o:borderbottomcolor")]
  public String? BorderBottomColor { get; set; }
  
  
  /// <summary>
  ///   Border Right Color
  /// </summary>
  [SchemaAttr("o:borderrightcolor")]
  public String? BorderRightColor { get; set; }
  
  
  /// <summary>
  ///   Diagram Node Layout Identifier
  /// </summary>
  [SchemaAttr("o:dgmlayout")]
  public Int64? DiagramLayout { get; set; }
  
  
  /// <summary>
  ///   Diagram Node Identifier
  /// </summary>
  [SchemaAttr("o:dgmnodekind")]
  public Int64? DiagramNodeKind { get; set; }
  
  
  /// <summary>
  ///   Diagram Node Recent Layout Identifier
  /// </summary>
  [SchemaAttr("o:dgmlayoutmru")]
  public Int64? DiagramLayoutMostRecentUsed { get; set; }
  
  
  /// <summary>
  ///   Text Inset Mode
  /// </summary>
  [SchemaAttr("o:insetmode")]
  public DocumentModel.Vml.Office.InsetMarginValues? InsetMode { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [SchemaAttr("filled")]
  public Boolean? Filled { get; set; }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  [SchemaAttr("fillcolor")]
  public String? FillColor { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  [SchemaAttr("stroked")]
  public Boolean? Stroked { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  [SchemaAttr("strokecolor")]
  public String? StrokeColor { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Weight
  /// </summary>
  [SchemaAttr("strokeweight")]
  public String? StrokeWeight { get; set; }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [SchemaAttr("insetpen")]
  public Boolean? InsetPen { get; set; }
  
  
  /// <summary>
  ///   Optional Number
  /// </summary>
  [SchemaAttr("o:spt")]
  public Int32? OptionalNumber { get; set; }
  
  
  /// <summary>
  ///   Shape Connector Type
  /// </summary>
  [SchemaAttr("o:connectortype")]
  public DocumentModel.Vml.Office.ConnectorValues? ConnectorType { get; set; }
  
  
  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  [SchemaAttr("o:bwmode")]
  public DocumentModel.Vml.Office.BlackAndWhiteModeValues? BlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  [SchemaAttr("o:bwpure")]
  public DocumentModel.Vml.Office.BlackAndWhiteModeValues? PureBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  [SchemaAttr("o:bwnormal")]
  public DocumentModel.Vml.Office.BlackAndWhiteModeValues? NormalBlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [SchemaAttr("o:forcedash")]
  public Boolean? ForceDash { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  [SchemaAttr("o:oleicon")]
  public Boolean? OleIcon { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  [SchemaAttr("o:ole")]
  public Boolean? Ole { get; set; }
  
  
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  [SchemaAttr("o:preferrelative")]
  public Boolean? PreferRelative { get; set; }
  
  
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  [SchemaAttr("o:cliptowrap")]
  public Boolean? ClipToWrap { get; set; }
  
  
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  [SchemaAttr("o:clip")]
  public Boolean? Clip { get; set; }
  
  
  /// <summary>
  ///   Image Source
  /// </summary>
  [SchemaAttr("src")]
  public String? Source { get; set; }
  
  
  /// <summary>
  ///   Image Left Crop
  /// </summary>
  [SchemaAttr("cropleft")]
  public String? CropLeft { get; set; }
  
  
  /// <summary>
  ///   Image Top Crop
  /// </summary>
  [SchemaAttr("croptop")]
  public String? CropTop { get; set; }
  
  
  /// <summary>
  ///   Image Right Crop
  /// </summary>
  [SchemaAttr("cropright")]
  public String? CropRight { get; set; }
  
  
  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  [SchemaAttr("cropbottom")]
  public String? CropBottom { get; set; }
  
  
  /// <summary>
  ///   Image Intensity
  /// </summary>
  [SchemaAttr("gain")]
  public String? Gain { get; set; }
  
  
  /// <summary>
  ///   Image Brightness
  /// </summary>
  [SchemaAttr("blacklevel")]
  public String? BlackLevel { get; set; }
  
  
  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  [SchemaAttr("gamma")]
  public String? Gamma { get; set; }
  
  
  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  [SchemaAttr("grayscale")]
  public Boolean? GrayScale { get; set; }
  
  
  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  [SchemaAttr("bilevel")]
  public Boolean? BiLevel { get; set; }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  [SchemaAttr("o:gfxdata")]
  public DocumentModel.Base64BinaryValue? Gfxdata { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
