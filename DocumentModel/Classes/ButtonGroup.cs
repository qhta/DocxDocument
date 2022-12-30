namespace DocumentModel;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
public partial class ButtonGroup
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterQulifiedId { get; set; }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeQulifiedId { get; set; }
  
  public DocumentModel.ControlCloneRegular? ControlCloneRegular { get; set; }
  
  public DocumentModel.ButtonRegular? ButtonRegular { get; set; }
  
  public DocumentModel.ToggleButtonRegular? ToggleButtonRegular { get; set; }
  
  public DocumentModel.GalleryRegular? GalleryRegular { get; set; }
  
  public DocumentModel.MenuRegular? MenuRegular { get; set; }
  
  public DocumentModel.DynamicMenuRegular? DynamicMenuRegular { get; set; }
  
  public DocumentModel.SplitButtonRegular? SplitButtonRegular { get; set; }
  
  public DocumentModel.Separator? Separator { get; set; }
  
}
