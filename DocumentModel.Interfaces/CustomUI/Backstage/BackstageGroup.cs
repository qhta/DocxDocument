namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageGroup Class.
/// </summary>
public interface BackstageGroup: IModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }

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
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   style
  /// </summary>
  public StyleKind? Style { get; set; }

  /// <summary>
  ///   getStyle
  /// </summary>
  public string? GetStyle { get; set; }

  /// <summary>
  ///   helperText
  /// </summary>
  public string? HelperText { get; set; }

  /// <summary>
  ///   getHelperText
  /// </summary>
  public string? GetHelperText { get; set; }

  /// <summary>
  ///   showLabel
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   getShowLabel
  /// </summary>
  public string? GetShowLabel { get; set; }

  public PrimaryItem? PrimaryItem { get; set; }

  public TopItemsGroupControls? TopItemsGroupControls { get; set; }

  public BottomItemsGroupControls? BottomItemsGroupControls { get; set; }
}