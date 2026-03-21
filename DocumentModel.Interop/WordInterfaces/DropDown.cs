namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a drop-down form field that contains a list of items in a form.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown?view=word-pia"/>
public interface DropDown : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.valid?view=word-pia"/>
  public bool Valid { get; }
  /// <summary>
  /// The default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.default?view=word-pia"/>
  public int Default { get; set; }
  /// <summary>
  /// The value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.value?view=word-pia"/>
  public int Value { get; set; }
  /// <summary>
  /// The list entries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.listentries?view=word-pia"/>
  public ListEntries ListEntries { get; }

}
