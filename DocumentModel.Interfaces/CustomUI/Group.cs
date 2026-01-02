namespace DocumentModel;

/// <summary>
///   Defines the Group Class.
/// </summary>
public class Group: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }
  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Image { get; set; }
  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ImageMso { get; set; }
  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetImage { get; set; }
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get; set; }
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get; set; }
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get; set; }
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get; set; }
  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get; set; }
  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get; set; }
  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get; set; }
  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get; set; }
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }
  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Keytip { get; set; }
  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get; set; }
  /// <summary>
  ///   autoScale, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? AutoScale { get; set; }
  /// <summary>
  ///   centerVertically, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? CenterVertically { get; set; }
  public ControlClone? ControlClone { get; set; }
  public LabelControl? LabelControl { get; set; }
  public Button? Button { get; set; }
  public ToggleButton? ToggleButton { get; set; }
  public ICheckBox? CheckBox { get; set; }
  public IEditBox? EditBox { get; set; }
  public IComboBox? ComboBox { get; set; }
  public IDropDownRegular? DropDownRegular { get; set; }
  public Gallery? Gallery { get; set; }
  public Menu? Menu { get; set; }
  public DynamicMenu? DynamicMenu { get; set; }
  public SplitButton? SplitButton { get; set; }
  public IBox? Box { get; set; }
  public ButtonGroup? ButtonGroup { get; set; }
  public Separator? Separator { get; set; }
  public DialogBoxLauncher? DialogBoxLauncher { get; set; }
}