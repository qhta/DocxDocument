namespace DocumentModel.UI;

/// <summary>
///   Defines the Box Class.
/// </summary>
public class Box: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public String? IdQ { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public String? GetVisible { get; set; }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }

  /// <summary>
  ///   boxStyle
  /// </summary>
  public BoxStyleKind? BoxStyle { get; set; }

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

  public Box? ChildBox { get; set; }

  public ButtonGroup? ButtonGroup { get; set; }
}