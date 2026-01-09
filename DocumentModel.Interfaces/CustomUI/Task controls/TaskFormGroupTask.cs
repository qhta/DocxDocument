namespace DocumentModel;

/// <summary>
/// Represents an individual task within a task form group category, supporting dynamic state, customizable appearance, and advanced callback integration for flexible task pane scenarios.
/// </summary>
/// <remarks>
/// This interface defines a single actionable task within a <c>TaskFormGroupCategory</c>. Tasks provide interactive elements with customizable appearance, behavior, and positioning within the task pane UI. The interface supports dynamic state, labeling, image customization, and integration with backstage groups for advanced Office add-in or document solutions.
/// </remarks>
public interface TaskFormGroupTask : CustomUIControl, BuiltInControl, BackstageGroupCollection
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Custom image identifier for the task icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the task icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic task image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Enable interaction with the task.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the task.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the task in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Description text for the task.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the task.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }
}