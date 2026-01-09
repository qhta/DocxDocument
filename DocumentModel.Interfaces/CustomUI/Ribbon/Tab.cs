namespace DocumentModel;

/// <summary>
/// Represents a tab in the Office ribbon interface that organizes groups of related commands and controls, supporting dynamic labeling, positioning, and advanced callback integration for Office UI extensibility.
/// </summary>
/// <remarks>
/// This interface defines a ribbon tab for Office applications, enabling organization of commands into logical groups. Tabs can be custom, built-in, or contextual, and support dynamic label, visibility, and keytip through callbacks. The interface allows precise positioning relative to built-in or custom tabs and supports integration of groups for efficient workflows and discoverable UI.
/// </remarks>
public interface Tab : CustomUIControl, BuiltInControl
{
  /// <summary>
  /// Arbitrary tag value for application-specific purposes.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Label text displayed for the tab in the ribbon.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the tab in the ribbon UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the tab.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip value.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Group or collection of groups contained within this tab.
  /// </summary>
  public Group? Group { get; set; }
}