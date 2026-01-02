namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Box Class.
/// </summary>
public class Box: ModelElement
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
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

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
  ///   boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public BoxStyleKind? BoxStyle { get; set; }

  public ControlClone? ControlClone { get; set; }

  public LabelControl? LabelControl { get; set; }

  public Button? Button { get; set; }

  public ToggleButton? ToggleButton { get; set; }

  public ICheckBox? CheckBox { get; set; }

  public EditBox? EditBox { get; set; }

  public ComboBox? ComboBox { get; set; }

  public DropDownRegular? DropDownRegular { get; set; }

  public Gallery? Gallery { get; set; }

  public Menu? Menu { get; set; }

  public DynamicMenu? DynamicMenu { get; set; }

  public SplitButton? SplitButton { get; set; }

  public Box? ChildBox { get; set; }

  public ButtonGroup? ButtonGroup { get; set; }
}