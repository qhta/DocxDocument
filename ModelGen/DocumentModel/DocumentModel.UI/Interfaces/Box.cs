namespace DocumentModel.UI;

/// <summary>
/// Defines the Box Class.
/// </summary>
public partial interface Box
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public String? IdQ { get; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible { get; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible { get; set; }
  
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
  /// boxStyle
  /// </summary>
  public DocumentModel.UI.BoxStyleKind? BoxStyle { get; set; }
  
  public DocumentModel.UI.ControlClone? ControlClone { get; set; }
  
  public DocumentModel.UI.TextLabel? TextLabel { get; set; }
  
  public DocumentModel.UI.Button? Button { get; set; }
  
  public DocumentModel.UI.ToggleButton? ToggleButton { get; set; }
  
  public DocumentModel.UI.CheckBox? CheckBox { get; set; }
  
  public DocumentModel.UI.EditBox? EditBox { get; set; }
  
  public DocumentModel.UI.ComboBox? ComboBox { get; set; }
  
  public DocumentModel.UI.DropDown? DropDown { get; set; }
  
  public DocumentModel.UI.Gallery? Gallery { get; set; }
  
  public DocumentModel.UI.Menu? Menu { get; set; }
  
  public DocumentModel.UI.DynamicMenu? DynamicMenu { get; set; }
  
  public DocumentModel.UI.SplitButton? SplitButton { get; set; }
  
  public DocumentModel.UI.Box? ChildBox { get; set; }
  
  public DocumentModel.UI.ButtonGroup? ButtonGroup { get; set; }
  
}
