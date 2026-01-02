namespace DocumentModel;

/// <summary>
///   Defines the ButtonGroup Class.
/// </summary>
public class ButtonGroup: ModelElement
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
  public ControlCloneRegular? ControlCloneRegular { get; set; }
  public ButtonRegular? ButtonRegular { get; set; }
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }
  public GalleryRegular? GalleryRegular { get; set; }
  public MenuRegular? MenuRegular { get; set; }
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }
  public SplitButtonRegular? SplitButtonRegular { get; set; }
  public Separator? Separator { get; set; }
}