namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the SplitButton Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IVisibleButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IVisibleToggleButton))]
public interface ISplitButton // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// size
  /// </summary>
  public DocumentModel.Office.CustomUI.SizeValues? Size { get ; set; }
  
  /// <summary>
  /// getSize
  /// </summary>
  public string? GetSize { get ; set; }
  
  /// <summary>
  /// enabled
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public string? GetEnabled { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public string? IdQ { get ; set; }
  
  /// <summary>
  /// idMso
  /// </summary>
  public string? IdMso { get ; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public string? Tag { get ; set; }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get ; set; }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get ; set; }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get ; set; }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get ; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// keytip
  /// </summary>
  public string? Keytip { get ; set; }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public string? GetKeytip { get ; set; }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public bool? ShowLabel { get ; set; }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public string? GetShowLabel { get ; set; }
  
}
