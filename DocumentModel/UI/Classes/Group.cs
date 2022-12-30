namespace DocumentModel.UI;

/// <summary>
/// Defines the Group Class.
/// </summary>
public partial class Group
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
  /// idMso
  /// </summary>
  public String? IdMso { get; set; }
  
  /// <summary>
  /// tag
  /// </summary>
  public String? Tag { get; set; }
  
  /// <summary>
  /// label
  /// </summary>
  public String? Label { get; set; }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public String? GetLabel { get; set; }
  
  /// <summary>
  /// image
  /// </summary>
  public String? Image { get; set; }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public String? ImageMso { get; set; }
  
  /// <summary>
  /// getImage
  /// </summary>
  public String? GetImage { get; set; }
  
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
  /// screentip
  /// </summary>
  public String? Screentip { get; set; }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public String? GetScreentip { get; set; }
  
  /// <summary>
  /// supertip
  /// </summary>
  public String? Supertip { get; set; }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public String? GetSupertip { get; set; }
  
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
  
  public DocumentModel.UI.Box? Box { get; set; }
  
  public DocumentModel.UI.ButtonGroup? ButtonGroup { get; set; }
  
  public DocumentModel.UI.VerticalSeparator? VerticalSeparator { get; set; }
  
  public DocumentModel.UI.DialogBoxLauncher? DialogBoxLauncher { get; set; }
  
}
