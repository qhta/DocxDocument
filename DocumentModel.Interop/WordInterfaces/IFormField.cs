namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield?view=word-pia"/>
public interface IFormField : IInteropObject
{
  /// <summary>
  /// Returns the field type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.type?view=word-pia"/>
  public FieldType Type { get; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns or sets an entry macro name for the specified form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.entrymacro?view=word-pia"/>
  public string EntryMacro { get; set; }

  /// <summary>
  /// Returns or sets an exit macro name for the specified form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.exitmacro?view=word-pia"/>
  public string ExitMacro { get; set; }

  /// <summary>
  /// Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.ownhelp?view=word-pia"/>
  public bool OwnHelp { get; set; }

  /// <summary>
  /// Specifies the source of the text that's displayed in the status bar when a form field has the focus.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.ownstatus?view=word-pia"/>
  public bool OwnStatus { get; set; }

  /// <summary>
  /// Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.helptext?view=word-pia"/>
  public string HelpText { get; set; }

  /// <summary>
  /// Returns or sets the text that's displayed in the status bar when a form field has the focus.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.statustext?view=word-pia"/>
  public string StatusText { get; set; }

  /// <summary>
  /// Determines if a form field is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.enabled?view=word-pia"/>
  public bool Enabled { get; set; }

  /// <summary>
  /// Returns a <see cref="IRange"/> object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.result?view=word-pia"/>
  public string Result { get; set; }

  /// <summary>
  /// Returns a <see cref="ITextInput"/> object that represents a text form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.textinput?view=word-pia"/>
  public ITextInput ITextInput { get; }

  /// <summary>
  /// Returns a <see cref="ICheckBox"/> object that represents a check box form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.checkbox?view=word-pia"/>
  public ICheckBox ICheckBox { get; }

  /// <summary>
  /// Returns a <see cref="IDropDown"/> object that represents a drop-down form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.dropdown?view=word-pia"/>
  public IDropDown IDropDown { get; }

  /// <summary>
  /// Returns the next object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.next?view=word-pia"/>
  public IFormField Next { get; }

  /// <summary>
  /// Returns the previous object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.previous?view=word-pia"/>
  public IFormField Previous { get; }

  /// <summary>
  /// Determines if references to the specified form field are automatically updated whenever the field is exited.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.calculateonexit?view=word-pia"/>
  public bool CalculateOnExit { get; set; }

  /// <summary>
  /// Returns a <see cref="IRange"/> object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.range?view=word-pia"/>
  public IRange range { get; }


  #region methods

/// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.formfield.select?view=word-pia"/>
  public void Select();

  #endregion methods
}
