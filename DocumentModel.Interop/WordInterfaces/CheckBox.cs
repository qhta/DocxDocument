namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single check box form field.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox?view=word-pia"/>
public interface CheckBox : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.valid?view=word-pia"/>
  public bool Valid { get; }
  /// <summary>
  /// The auto size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.autosize?view=word-pia"/>
  public bool AutoSize { get; set; }
  /// <summary>
  /// The size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.size?view=word-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// The default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.default?view=word-pia"/>
  public bool Default { get; set; }
  /// <summary>
  /// The value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.value?view=word-pia"/>
  public bool Value { get; set; }

}
