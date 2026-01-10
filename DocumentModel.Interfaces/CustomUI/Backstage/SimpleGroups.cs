namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a collection of simple group containers for organizing controls in Office UI customizations.
/// Simple groups provide basic grouping and layout capabilities for Backstage tabs and task panes,
/// offering a streamlined alternative to more complex layout containers.
/// </summary>
public interface SimpleGroups
{
  /// <summary>
  /// Gets or sets a group container for organizing content in the Backstage view.
  /// </summary>
 
  public BackstageGroup? BackstageGroup { get; set; }

  /// <summary>
  /// Gets or sets a group container for organizing controls in custom task panes.
  /// </summary>
  public TaskGroup? TaskGroup { get; set; }
}