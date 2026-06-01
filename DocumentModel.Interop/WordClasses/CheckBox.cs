namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single check box form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox?view=word-pia"/>
public class CheckBox : InteropObject
{
  /// <summary>
  /// Gets a value indicating whether the `CheckBox` object is valid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.valid?view=word-pia"/>
  public bool Valid { get; }
  /// <summary>
  /// Gets or sets a value indicating whether the check box is automatically sized.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.autosize?view=word-pia"/>
  public bool AutoSize { get; set; }
  /// <summary>
  /// Gets or sets the size of the check box, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.size?view=word-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the default value of the check box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.default?view=word-pia"/>
  public bool Default { get; set; }
  /// <summary>
  /// Gets or sets the current value of the check box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.checkbox.value?view=word-pia"/>
  public bool Value { get; set; }

}
