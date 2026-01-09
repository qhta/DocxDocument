namespace DocumentModel;

/// <summary>
/// Represents an edit box control that provides a text input field for user entry in the ribbon interface, supporting customizable appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a text input control that allows users to enter and edit text directly within the ribbon. Unlike a <see cref="ComboBox"/> which combines text input with a dropdown list, the edit box provides a simple text field without predefined options. The control supports text length constraints, change notifications, customizable appearance with images and labels, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface EditBox : BoxContentControl
{
  /// <summary>
  /// Enable interaction with the edit box.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Custom image identifier for the edit box icon.
  /// </summary>
  public string? Image { get; set; }

  /// <summary>
  /// Built-in Office image identifier for the edit box icon.
  /// </summary>
  public string? ImageMso { get; set; }

  /// <summary>
  /// Callback for dynamic edit box image.
  /// </summary>
  public string? GetImage { get; set; }

  /// <summary>
  /// Maximum number of characters that can be entered in the text field.
  /// </summary>
  public Int64? MaxLength { get; set; }

  /// <summary>
  /// Callback for dynamic text value of the edit box.
  /// </summary>
  public string? GetText { get; set; }

  /// <summary>
  /// Callback executed when the edit box text changes.
  /// </summary>
  public string? OnChange { get; set; }

  /// <summary>
  /// String representation of the edit box size in the ribbon.
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  /// Arbitrary tag value for custom data storage.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  /// Built-in Office identifier for an edit box control.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  /// Screentip text for the edit box.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  /// Callback for dynamic screentip text.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  /// Supertip text for the edit box.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  /// Callback for dynamic supertip text.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  /// Label text for the edit box.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the edit box in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the edit box.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Show the edit box label in the UI.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Callback for dynamic label visibility.
  /// </summary>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Show the edit box image in the UI.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  /// Callback for dynamic image visibility.
  /// </summary>
  public string? GetShowImage { get; set; }
}