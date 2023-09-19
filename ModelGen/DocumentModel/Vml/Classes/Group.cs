namespace DocumentModel.Vml;


/// <summary>
///   Shape Group.
/// </summary>
public partial class Group
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
  ///   spid
  /// </summary>
  [SchemaAttr("o:spid")]
  public String? OptionalString { get; set; }
  
  
  /// <summary>
  ///   oned
  /// </summary>
  [SchemaAttr("o:oned")]
  public Boolean? Oned { get; set; }
  
  
  /// <summary>
  ///   regroupid
  /// </summary>
  [SchemaAttr("o:regroupid")]
  public Int64? RegroupId { get; set; }
  
  
  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  [SchemaAttr("o:doubleclicknotify")]
  public Boolean? DoubleClickNotify { get; set; }
  
  
  /// <summary>
  ///   button
  /// </summary>
  [SchemaAttr("o:button")]
  public Boolean? Button { get; set; }
  
  
  /// <summary>
  ///   userhidden
  /// </summary>
  [SchemaAttr("o:userhidden")]
  public Boolean? UserHidden { get; set; }
  
  
  /// <summary>
  ///   bullet
  /// </summary>
  [SchemaAttr("o:bullet")]
  public Boolean? Bullet { get; set; }
  
  
  /// <summary>
  ///   hr
  /// </summary>
  [SchemaAttr("o:hr")]
  public Boolean? Horizontal { get; set; }
  
  
  /// <summary>
  ///   hrstd
  /// </summary>
  [SchemaAttr("o:hrstd")]
  public Boolean? HorizontalStandard { get; set; }
  
  
  /// <summary>
  ///   hrnoshade
  /// </summary>
  [SchemaAttr("o:hrnoshade")]
  public Boolean? HorizontalNoShade { get; set; }
  
  
  /// <summary>
  ///   hrpct
  /// </summary>
  [SchemaAttr("o:hrpct")]
  public Single? HorizontalPercentage { get; set; }
  
  
  /// <summary>
  ///   hralign
  /// </summary>
  [SchemaAttr("o:hralign")]
  public DocumentModel.Vml.Office.HorizontalRuleAlignmentValues? HorizontalAlignment { get; set; }
  
  
  /// <summary>
  ///   allowincell
  /// </summary>
  [SchemaAttr("o:allowincell")]
  public Boolean? AllowInCell { get; set; }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  [SchemaAttr("o:allowoverlap")]
  public Boolean? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   userdrawn
  /// </summary>
  [SchemaAttr("o:userdrawn")]
  public Boolean? UserDrawn { get; set; }
  
  
  /// <summary>
  ///   dgmlayout
  /// </summary>
  [SchemaAttr("o:dgmlayout")]
  public Int64? DiagramLayout { get; set; }
  
  
  /// <summary>
  ///   dgmnodekind
  /// </summary>
  [SchemaAttr("o:dgmnodekind")]
  public Int64? DiagramNodeKind { get; set; }
  
  
  /// <summary>
  ///   dgmlayoutmru
  /// </summary>
  [SchemaAttr("o:dgmlayoutmru")]
  public Int64? DiagramLayoutMostRecentUsed { get; set; }
  
  
  /// <summary>
  ///   insetmode
  /// </summary>
  [SchemaAttr("o:insetmode")]
  public DocumentModel.Vml.Office.InsetMarginValues? InsetMode { get; set; }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  [SchemaAttr("o:gfxdata")]
  public DocumentModel.Base64BinaryValue? Gfxdata { get; set; }
  
  
  /// <summary>
  ///   Group Diagram Type
  /// </summary>
  [SchemaAttr("editas")]
  public DocumentModel.Vml.EditAsValues? EditAs { get; set; }
  
  
  /// <summary>
  ///   Table Properties
  /// </summary>
  [SchemaAttr("o:tableproperties")]
  public String? TableProperties { get; set; }
  
  
  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  [SchemaAttr("o:tablelimits")]
  public String? TableLimits { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
