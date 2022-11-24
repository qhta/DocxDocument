namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public interface IGroup // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// spid
  /// </summary>
  public String? OptionalString { get ; set; }
  
  /// <summary>
  /// oned
  /// </summary>
  public ITrueFalseValue? Oned { get ; set; }
  
  /// <summary>
  /// regroupid
  /// </summary>
  public Int32? RegroupId { get ; set; }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  public ITrueFalseValue? DoubleClickNotify { get ; set; }
  
  /// <summary>
  /// button
  /// </summary>
  public ITrueFalseValue? Button { get ; set; }
  
  /// <summary>
  /// userhidden
  /// </summary>
  public ITrueFalseValue? UserHidden { get ; set; }
  
  /// <summary>
  /// bullet
  /// </summary>
  public ITrueFalseValue? Bullet { get ; set; }
  
  /// <summary>
  /// hr
  /// </summary>
  public ITrueFalseValue? Horizontal { get ; set; }
  
  /// <summary>
  /// hrstd
  /// </summary>
  public ITrueFalseValue? HorizontalStandard { get ; set; }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  public ITrueFalseValue? HorizontalNoShade { get ; set; }
  
  /// <summary>
  /// hrpct
  /// </summary>
  public Single? HorizontalPercentage { get ; set; }
  
  /// <summary>
  /// hralign
  /// </summary>
  public HorizontalRuleAlignmentValues? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// allowincell
  /// </summary>
  public ITrueFalseValue? AllowInCell { get ; set; }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public ITrueFalseValue? AllowOverlap { get ; set; }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  public ITrueFalseValue? UserDrawn { get ; set; }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  public Int32? DiagramLayout { get ; set; }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  public Int32? DiagramNodeKind { get ; set; }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed { get ; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public InsetMarginValues? InsetMode { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public IBase64BinaryValue? Gfxdata { get ; set; }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public EditAsValues? EditAs { get ; set; }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  public String? TableProperties { get ; set; }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  public String? TableLimits { get ; set; }
  
}
