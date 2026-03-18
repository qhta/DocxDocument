namespace DocumentModel.Interop;

/// <summary>
/// Represents a single form field.
/// </summary>
public partial interface FormField : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdFieldType Type { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The entry macro.
  /// </summary>
  public string EntryMacro { get; set; }

  /// <summary>
  /// The exit macro.
  /// </summary>
  public string ExitMacro { get; set; }

  /// <summary>
  /// The own help.
  /// </summary>
  public bool OwnHelp { get; set; }

  /// <summary>
  /// The own status.
  /// </summary>
  public bool OwnStatus { get; set; }

  /// <summary>
  /// The help text.
  /// </summary>
  public string HelpText { get; set; }

  /// <summary>
  /// The status text.
  /// </summary>
  public string StatusText { get; set; }

  /// <summary>
  /// The enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// The result.
  /// </summary>
  public string Result { get; set; }

  /// <summary>
  /// The text input.
  /// </summary>
  public TextInput TextInput { get; }

  /// <summary>
  /// The check box.
  /// </summary>
  public CheckBox CheckBox { get; }

  /// <summary>
  /// The drop down.
  /// </summary>
  public DropDown DropDown { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public FormField Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public FormField Previous { get; }

  /// <summary>
  /// The calculate on exit.
  /// </summary>
  public bool CalculateOnExit { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
}
