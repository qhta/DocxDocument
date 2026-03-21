namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single check box form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox?view=word-pia"/>
public interface CheckBox : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.valid?view=word-pia"/>
  public bool Valid { get; }
  /// <summary>
  /// The auto size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.autosize?view=word-pia"/>
  public bool AutoSize { get; set; }
  /// <summary>
  /// The size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.size?view=word-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// The default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.default?view=word-pia"/>
  public bool Default { get; set; }
  /// <summary>
  /// The value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.value?view=word-pia"/>
  public bool Value { get; set; }

}
