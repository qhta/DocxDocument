namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single text form field.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput?view=word-pia"/>
public partial interface ITextInput : IModelObject
{
  /// <summary>
  /// True if the specified form field object is a valid check box form field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.valid?view=word-pia"/>
  public bool Valid { get; }

  /// <summary>
  /// Returns or sets the text that represents the default text box contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.default?view=word-pia"/>
  public string Default { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the type of text form field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.type?view=word-pia"/>
  public TextBoxFormField Type { get; }

  /// <summary>
  /// Returns the text formatting for the specified text box.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.format?view=word-pia"/>
  public string Format { get; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.width?view=word-pia"/>
  public int Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
