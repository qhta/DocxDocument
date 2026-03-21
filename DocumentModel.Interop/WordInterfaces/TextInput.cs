namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single text form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput?view=word-pia"/>
public partial interface TextInput : InteropObject
{
  /// <summary>
  /// Returns whether valid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.valid?view=word-pia"/>
  public bool Valid { get; }

  /// <summary>
  /// Returns or sets the default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.default?view=word-pia"/>
  public string Default { get; set; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.type?view=word-pia"/>
  public WdTextFormFieldType Type { get; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.format?view=word-pia"/>
  public string Format { get; }

  /// <summary>
  /// Returns or sets the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textinput.width?view=word-pia"/>
  public int Width { get; set; }
}
