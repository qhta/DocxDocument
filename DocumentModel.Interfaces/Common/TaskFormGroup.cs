namespace DocumentModel;

/// <summary>
///   Defines the TaskFormGroup Class.
/// </summary>
public class TaskFormGroup: ModelElement
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
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }
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
  /// <summary>
  ///   allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  public TaskSizesKind? AllowedTaskSizes { get; set; }
  public Collection<TaskFormGroupCategory>? TaskFormGroupCategories { get; set; }
}