namespace DocumentModel.Vml;


/// <summary>
///   Shape Group.
/// </summary>
public partial class Group
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  public String? Target { get; set; }
  
  
  /// <summary>
  ///   CSS Reference
  /// </summary>
  public String? Class { get; set; }
  
  
  /// <summary>
  ///   Shape Title
  /// </summary>
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Alternate Text
  /// </summary>
  public String? Alternate { get; set; }
  
  
  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  public String? CoordinateSize { get; set; }
  
  
  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  public String? CoordinateOrigin { get; set; }
  
  
  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  public String? WrapCoordinates { get; set; }
  
  
  /// <summary>
  ///   Print Toggle
  /// </summary>
  public DM.TrueFalseValue? Print { get; set; }
  
  
  /// <summary>
  ///   spid
  /// </summary>
  public String? OptionalString { get; set; }
  
  
  /// <summary>
  ///   oned
  /// </summary>
  public DM.TrueFalseValue? Oned { get; set; }
  
  
  /// <summary>
  ///   regroupid
  /// </summary>
  public Int64? RegroupId { get; set; }
  
  
  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  public DM.TrueFalseValue? DoubleClickNotify { get; set; }
  
  
  /// <summary>
  ///   button
  /// </summary>
  public DM.TrueFalseValue? Button { get; set; }
  
  
  /// <summary>
  ///   userhidden
  /// </summary>
  public DM.TrueFalseValue? UserHidden { get; set; }
  
  
  /// <summary>
  ///   bullet
  /// </summary>
  public DM.TrueFalseValue? Bullet { get; set; }
  
  
  /// <summary>
  ///   hr
  /// </summary>
  public DM.TrueFalseValue? Horizontal { get; set; }
  
  
  /// <summary>
  ///   hrstd
  /// </summary>
  public DM.TrueFalseValue? HorizontalStandard { get; set; }
  
  
  /// <summary>
  ///   hrnoshade
  /// </summary>
  public DM.TrueFalseValue? HorizontalNoShade { get; set; }
  
  
  /// <summary>
  ///   hrpct
  /// </summary>
  public Single? HorizontalPercentage { get; set; }
  
  
  /// <summary>
  ///   hralign
  /// </summary>
  public DocumentModel.Vml.Office.HorizontalRuleAlignmentKind? HorizontalAlignment { get; set; }
  
  
  /// <summary>
  ///   allowincell
  /// </summary>
  public DM.TrueFalseValue? AllowInCell { get; set; }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  public DM.TrueFalseValue? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   userdrawn
  /// </summary>
  public DM.TrueFalseValue? UserDrawn { get; set; }
  
  
  /// <summary>
  ///   dgmlayout
  /// </summary>
  public Int64? DiagramLayout { get; set; }
  
  
  /// <summary>
  ///   dgmnodekind
  /// </summary>
  public Int64? DiagramNodeKind { get; set; }
  
  
  /// <summary>
  ///   dgmlayoutmru
  /// </summary>
  public Int64? DiagramLayoutMostRecentUsed { get; set; }
  
  
  /// <summary>
  ///   insetmode
  /// </summary>
  public DocumentModel.Vml.Office.InsetMarginKind? InsetMode { get; set; }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  public DM.Base64Binary? Gfxdata { get; set; }
  
  
  /// <summary>
  ///   Group Diagram Type
  /// </summary>
  public DocumentModel.Vml.EditAsKind? EditAs { get; set; }
  
  
  /// <summary>
  ///   Table Properties
  /// </summary>
  public String? TableProperties { get; set; }
  
  
  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  public String? TableLimits { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
