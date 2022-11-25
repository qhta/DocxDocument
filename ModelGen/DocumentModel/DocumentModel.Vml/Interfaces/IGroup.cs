namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public interface IGroup // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// spid
  /// </summary>
  public System.String? OptionalString { get ; set; }
  
  /// <summary>
  /// oned
  /// </summary>
  public System.Boolean? Oned { get ; set; }
  
  /// <summary>
  /// regroupid
  /// </summary>
  public System.Int32? RegroupId { get ; set; }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  public System.Boolean? DoubleClickNotify { get ; set; }
  
  /// <summary>
  /// button
  /// </summary>
  public System.Boolean? Button { get ; set; }
  
  /// <summary>
  /// userhidden
  /// </summary>
  public System.Boolean? UserHidden { get ; set; }
  
  /// <summary>
  /// bullet
  /// </summary>
  public System.Boolean? Bullet { get ; set; }
  
  /// <summary>
  /// hr
  /// </summary>
  public System.Boolean? Horizontal { get ; set; }
  
  /// <summary>
  /// hrstd
  /// </summary>
  public System.Boolean? HorizontalStandard { get ; set; }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  public System.Boolean? HorizontalNoShade { get ; set; }
  
  /// <summary>
  /// hrpct
  /// </summary>
  public System.Single? HorizontalPercentage { get ; set; }
  
  /// <summary>
  /// hralign
  /// </summary>
  public DocumentModel.Vml.Office.HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// allowincell
  /// </summary>
  public System.Boolean? AllowInCell { get ; set; }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public System.Boolean? AllowOverlap { get ; set; }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  public System.Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  public System.Int32? DiagramLayout { get ; set; }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  public System.Int32? DiagramNodeKind { get ; set; }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  public System.Int32? DiagramLayoutMostRecentUsed { get ; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public DocumentModel.Vml.Office.InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.IBase64BinaryValue? Gfxdata { get ; set; }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public DocumentModel.Vml.EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  public System.String? TableProperties { get ; set; }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  public System.String? TableLimits { get ; set; }
  
}
