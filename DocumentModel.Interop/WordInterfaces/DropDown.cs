namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a drop-down form field that contains a list of items in a form.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown?view=word-pia"/>
public interface DropDown : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.valid?view=word-pia"/>
  public bool Valid { get; }
  /// <summary>
  /// The default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.default?view=word-pia"/>
  public int Default { get; set; }
  /// <summary>
  /// The value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.value?view=word-pia"/>
  public int Value { get; set; }
  /// <summary>
  /// The list entries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.listentries?view=word-pia"/>
  public ListEntries ListEntries { get; }

}
