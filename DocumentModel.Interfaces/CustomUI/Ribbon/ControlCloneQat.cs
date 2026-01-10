namespace DocumentModel;

/// <summary>
/// Represents a cloned control specifically designed for the Quick Access Toolbar (QAT) in Office applications, supporting dynamic state, customizable appearance, and advanced callback integration for compact UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a control clone optimized for the QAT, enabling replication of built-in Office commands or custom controls with tailored appearance, behavior, and positioning. The cloned control inherits base functionality but can override properties such as size, label, image, visibility, enabled state, and QAT-specific layout. All properties can be set statically or determined dynamically through callback functions for responsive UI.
/// </remarks>
public interface ControlCloneQat : CustomUIControl, BuiltInObject, QatItem
{
  /// <summary>
  /// Description text for the QAT control.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Callback for dynamic description text.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  /// Size of the cloned control in the Quick Access Toolbar.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  /// Callback for dynamic size selection.
  /// </summary>
  public string? GetSize { get; set; }

  /// <summary>
  /// Custom image identifier for the QAT control's icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the QAT control's icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic QAT control image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Screentip text for the QAT control.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the QAT control.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Enable interaction with the QAT control.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the QAT control.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the QAT control in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the QAT control.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the QAT control's label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the QAT control's image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }
}