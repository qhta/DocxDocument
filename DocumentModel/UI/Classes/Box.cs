namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Box Class.
/// </summary>
public class Box: ModelElement
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
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }

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