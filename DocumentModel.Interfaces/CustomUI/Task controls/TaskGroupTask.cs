namespace DocumentModel;

/// <summary>
/// Represents a task item within a task group category for Office UI, supporting dynamic state, customizable appearance, and advanced callback integration for flexible task management scenarios.
/// </summary>
/// <remarks>
/// This interface defines a task group task for Office UI, enabling tagging, action callbacks, definitive state, image customization, dynamic state, labeling, visibility, description, and keytip support. It supports advanced workflows for task management, integration, and extensibility in Office add-ins or document solutions.
/// </remarks>
public interface TaskGroupTask : CustomUIControl, BuiltInControl
{
  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Callback executed when the task is activated.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  /// Indicates whether the task is definitive.
  /// </summary>
  public bool? IsDefinitive { get; set; }

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