namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a collection of group controls for the Office Backstage view, supporting flexible arrangement and advanced customization for Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface provides access to various group types that can be displayed in the Backstage view, including task form groups, standard Backstage groups, and task groups. It enables comprehensive organization and customization of Backstage layouts in Office applications.
/// </remarks>
public interface BackstageGroups
{
  /// <summary>
  /// Task form group displayed in the Backstage view.
  /// </summary>
  public TaskFormGroup? TaskFormGroup { get; set; }

  /// <summary>
  /// Standard Backstage group displayed in the Backstage view.
  /// </summary>
  public BackstageGroup? BackstageGroup { get; set; }

  /// <summary>
  /// Task group displayed in the Backstage view.
  /// </summary>
  public TaskGroup? TaskGroup { get; set; }
}