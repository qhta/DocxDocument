namespace DocumentModel.UI;

/// <summary>
///   Defines the Group Class.
/// </summary>
public class Group: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ
  /// </summary>
  public string? IdQ { get; set; }
  /// <summary>
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }
  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }
  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }
  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }
  /// <summary>
  ///   image
  /// </summary>
  public string? Image { get; set; }
  /// <summary>
  ///   imageMso
  /// </summary>
  public string? ImageMso { get; set; }
  /// <summary>
  ///   getImage
  /// </summary>
  public string? GetImage { get; set; }
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get; set; }
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get; set; }
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get; set; }
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get; set; }
  /// <summary>
  ///   screentip
  /// </summary>
  public string? Screentip { get; set; }
  /// <summary>
  ///   getScreentip
  /// </summary>
  public string? GetScreentip { get; set; }
  /// <summary>
  ///   supertip
  /// </summary>
  public string? Supertip { get; set; }
  /// <summary>
  ///   getSupertip
  /// </summary>
  public string? GetSupertip { get; set; }
  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }
  /// <summary>
  ///   keytip
  /// </summary>
  public string? Keytip { get; set; }
  /// <summary>
  ///   getKeytip
  /// </summary>
  public string? GetKeytip { get; set; }
  public ControlClone? ControlClone { get; set; }
  public TextLabel? TextLabel { get; set; }
  public Button? Button { get; set; }
  public ToggleButton? ToggleButton { get; set; }
  public CheckBox? CheckBox { get; set; }
  public EditBox? EditBox { get; set; }
  public ComboBox? ComboBox { get; set; }
  public DropDown? DropDown { get; set; }
  public Gallery? Gallery { get; set; }
  public Menu? Menu { get; set; }
  public DynamicMenu? DynamicMenu { get; set; }
  public SplitButton? SplitButton { get; set; }
  public Box? Box { get; set; }
  public ButtonGroup? ButtonGroup { get; set; }
  public VerticalSeparator? VerticalSeparator { get; set; }
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }
}