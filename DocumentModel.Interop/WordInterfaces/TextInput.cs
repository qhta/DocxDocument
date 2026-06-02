namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single text form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput?view=word-pia"/>
public partial interface ITextInput : IInteropObject
{
  /// <summary>
  /// True if the specified form field object is a valid check box form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.valid?view=word-pia"/>
  public bool Valid { get; }

  /// <summary>
  /// Returns or sets the text that represents the default text box contents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.default?view=word-pia"/>
  public string Default { get; set; }

  /// <summary>
  /// Returns the type of text form field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.type?view=word-pia"/>
  public TextFormFieldType Type { get; }

  /// <summary>
  /// Returns the text formatting for the specified text box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.format?view=word-pia"/>
  public string Format { get; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.width?view=word-pia"/>
  public int Width { get; set; }


  #region methods

/// <summary>
  /// Deletes the text from the specified text form field.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.clear?view=word-pia"/>
  public void Clear();

  #endregion methods
}
