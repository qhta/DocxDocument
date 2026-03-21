namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield?view=word-pia"/>
public partial interface FormField : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.type?view=word-pia"/>
  public WdFieldType Type { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The entry macro.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.entrymacro?view=word-pia"/>
  public string EntryMacro { get; set; }

  /// <summary>
  /// The exit macro.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.exitmacro?view=word-pia"/>
  public string ExitMacro { get; set; }

  /// <summary>
  /// The own help.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.ownhelp?view=word-pia"/>
  public bool OwnHelp { get; set; }

  /// <summary>
  /// The own status.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.ownstatus?view=word-pia"/>
  public bool OwnStatus { get; set; }

  /// <summary>
  /// The help text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.helptext?view=word-pia"/>
  public string HelpText { get; set; }

  /// <summary>
  /// The status text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.statustext?view=word-pia"/>
  public string StatusText { get; set; }

  /// <summary>
  /// The enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.enabled?view=word-pia"/>
  public bool Enabled { get; set; }

  /// <summary>
  /// The result.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.result?view=word-pia"/>
  public string Result { get; set; }

  /// <summary>
  /// The text input.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.textinput?view=word-pia"/>
  public TextInput TextInput { get; }

  /// <summary>
  /// The check box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.checkbox?view=word-pia"/>
  public CheckBox CheckBox { get; }

  /// <summary>
  /// The drop down.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.dropdown?view=word-pia"/>
  public DropDown DropDown { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.next?view=word-pia"/>
  public FormField Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.previous?view=word-pia"/>
  public FormField Previous { get; }

  /// <summary>
  /// The calculate on exit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.calculateonexit?view=word-pia"/>
  public bool CalculateOnExit { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.range?view=word-pia"/>
  public Range Range { get; }
}
