namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ButtonGroup Class.
/// </summary>
public class ButtonGroup: ModelElement
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
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }

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

  public ControlCloneRegular? ControlCloneRegular { get; set; }

  public ButtonRegular? ButtonRegular { get; set; }

  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  public GalleryRegular? GalleryRegular { get; set; }

  public MenuRegular? MenuRegular { get; set; }

  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  public SplitButtonRegular? SplitButtonRegular { get; set; }

  public Separator? Separator { get; set; }
}