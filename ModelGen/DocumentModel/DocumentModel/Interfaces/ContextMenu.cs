namespace DocumentModel;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
public partial interface ContextMenu
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso { get; set; }
  
  public DocumentModel.ControlCloneRegular? ControlCloneRegular { get; set; }
  
  public DocumentModel.ButtonRegular? ButtonRegular { get; set; }
  
  public DocumentModel.CheckBox? CheckBox { get; set; }
  
  public DocumentModel.GalleryRegular? GalleryRegular { get; set; }
  
  public DocumentModel.ToggleButtonRegular? ToggleButtonRegular { get; set; }
  
  public DocumentModel.SplitButtonRegular? SplitButtonRegular { get; set; }
  
  public DocumentModel.MenuRegular? MenuRegular { get; set; }
  
  public DocumentModel.DynamicMenuRegular? DynamicMenuRegular { get; set; }
  
  public DocumentModel.MenuSeparatorNoTitle? MenuSeparatorNoTitle { get; set; }
  
}
