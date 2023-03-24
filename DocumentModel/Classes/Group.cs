namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Group Class.
/// </summary>
public class Group: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }

  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }

  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Image { get; set; }

  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ImageMso { get; set; }

  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetImage { get; set; }

  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterQulifiedId { get; set; }

  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeQulifiedId { get; set; }

  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Screentip { get; set; }

  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetScreentip { get; set; }

  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Supertip { get; set; }

  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetSupertip { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }

  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Keytip { get; set; }

  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetKeytip { get; set; }

  /// <summary>
  ///   autoScale, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AutoScale { get; set; }

  /// <summary>
  ///   centerVertically, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? CenterVertically { get; set; }

  public ControlClone? ControlClone { get; set; }

  public LabelControl? LabelControl { get; set; }

  public Button? Button { get; set; }

  public ToggleButton? ToggleButton { get; set; }

  public CheckBox? CheckBox { get; set; }

  public EditBox? EditBox { get; set; }

  public ComboBox? ComboBox { get; set; }

  public DropDownRegular? DropDownRegular { get; set; }

  public Gallery? Gallery { get; set; }

  public Menu? Menu { get; set; }

  public DynamicMenu? DynamicMenu { get; set; }

  public SplitButton? SplitButton { get; set; }

  public Box? Box { get; set; }

  public ButtonGroup? ButtonGroup { get; set; }

  public Separator? Separator { get; set; }

  public DialogBoxLauncher? DialogBoxLauncher { get; set; }
}