namespace DocumentModel.UI;

/// <summary>
/// Defines the SplitButton Class.
/// </summary>
public partial class SplitButton
{
  /// <summary>
  /// size
  /// </summary>
  public DocumentModel.UI.SizeKind? Size { get; set; }
  
  /// <summary>
  /// getSize
  /// </summary>
  public String? GetSize { get; set; }
  
  /// <summary>
  /// enabled
  /// </summary>
  public Boolean? Enabled { get; set; }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public String? GetEnabled { get; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public String? IdQ { get; set; }
  
  /// <summary>
  /// idMso
  /// </summary>
  public String? IdMso { get; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public String? Tag { get; set; }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible { get; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible { get; set; }
  
  /// <summary>
  /// keytip
  /// </summary>
  public String? Keytip { get; set; }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public String? GetKeytip { get; set; }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public Boolean? ShowLabel { get; set; }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public String? GetShowLabel { get; set; }
  
  public DocumentModel.UI.VisibleButton? VisibleButton { get; set; }
  
  public DocumentModel.UI.VisibleToggleButton? VisibleToggleButton { get; set; }
  
  public DocumentModel.UI.UnsizedMenu? UnsizedMenu { get; set; }
  
}
