namespace DocumentModel;

/// <summary>
///   Defines the TaskGroup Class.
/// </summary>
public record TaskGroup
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
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }

  /// <summary>
  ///   helperText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? HelperText { get; set; }

  /// <summary>
  ///   getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetHelperText { get; set; }

  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowLabel { get; set; }

  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetShowLabel { get; set; }

  /// <summary>
  ///   allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  public TaskSizesKind? AllowedTaskSizes { get; set; }

  public Collection<TaskGroupCategory>? TaskGroupCategories { get; set; }
}