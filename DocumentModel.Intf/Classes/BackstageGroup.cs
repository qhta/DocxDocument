namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageGroup Class.
/// </summary>
public class BackstageGroup: ModelElement
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
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   style, this property is only available in Office 2010 and later.
  /// </summary>
  public StyleKind? Style { get; set; }

  /// <summary>
  ///   getStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetStyle { get; set; }

  /// <summary>
  ///   helperText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? HelperText { get; set; }

  /// <summary>
  ///   getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetHelperText { get; set; }

  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetShowLabel { get; set; }

  public PrimaryItem? PrimaryItem { get; set; }

  public TopItemsGroupControls? TopItemsGroupControls { get; set; }

  public BottomItemsGroupControls? BottomItemsGroupControls { get; set; }
}