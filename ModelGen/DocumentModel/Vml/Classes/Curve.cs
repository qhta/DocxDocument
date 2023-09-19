namespace DocumentModel.Vml;


/// <summary>
///   Bezier Curve.
/// </summary>
public partial class Curve
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [SchemaAttr("style")]
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [SchemaAttr("href")]
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  [SchemaAttr("target")]
  public String? Target { get; set; }
  
  
  /// <summary>
  ///   CSS Reference
  /// </summary>
  [SchemaAttr("class")]
  public String? Class { get; set; }
  
  
  /// <summary>
  ///   Shape Title
  /// </summary>
  [SchemaAttr("title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Alternate Text
  /// </summary>
  [SchemaAttr("alt")]
  public String? Alternate { get; set; }
  
  
  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  [SchemaAttr("coordsize")]
  public String? CoordinateSize { get; set; }
  
  
  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  [SchemaAttr("coordorigin")]
  public String? CoordinateOrigin { get; set; }
  
  
  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  [SchemaAttr("wrapcoords")]
  public String? WrapCoordinates { get; set; }
  
  
  /// <summary>
  ///   Print Toggle
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
  ///   Encoded Package
  /// </summary>
  [SchemaAttr("o:gfxdata")]
  public DocumentModel.Base64BinaryValue? Gfxdata { get; set; }
  
  
  /// <summary>
  ///   Curve Starting Point
  /// </summary>
  [SchemaAttr("from")]
  public String? From { get; set; }
  
  
  /// <summary>
  ///   First Curve Control Point
  /// </summary>
  [SchemaAttr("control1")]
  public String? Control1 { get; set; }
  
  
  /// <summary>
  ///   Second Curve Control Point
  /// </summary>
  [SchemaAttr("control2")]
  public String? Control2 { get; set; }
  
  
  /// <summary>
  ///   Curve Ending Point
  /// </summary>
  [SchemaAttr("to")]
  public String? To { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
