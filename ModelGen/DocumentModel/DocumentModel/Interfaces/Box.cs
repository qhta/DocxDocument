namespace DocumentModel;

/// <summary>
/// Defines the Box Class.
/// </summary>
public partial interface Box
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
  
  /// <summary>
  /// boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.BoxStyleKind? BoxStyle { get; set; }
  
  public DocumentModel.ControlClone? ControlClone { get; set; }
  
  public DocumentModel.LabelControl? LabelControl { get; set; }
  
  public DocumentModel.Button? Button { get; set; }
  
  public DocumentModel.ToggleButton? ToggleButton { get; set; }
  
  public DocumentModel.CheckBox? CheckBox { get; set; }
  
  public DocumentModel.EditBox? EditBox { get; set; }
  
  public DocumentModel.ComboBox? ComboBox { get; set; }
  
  public DocumentModel.DropDownRegular? DropDownRegular { get; set; }
  
  public DocumentModel.Gallery? Gallery { get; set; }
  
  public DocumentModel.Menu? Menu { get; set; }
  
  public DocumentModel.DynamicMenu? DynamicMenu { get; set; }
  
  public DocumentModel.SplitButton? SplitButton { get; set; }
  
  public DocumentModel.Box? ChildBox { get; set; }
  
  public DocumentModel.ButtonGroup? ButtonGroup { get; set; }
  
}
