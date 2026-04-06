namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a drop-down form field that contains a list of items in a form.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown?view=word-pia"/>
public interface IDropDown : IModelObject
{
  /// <summary>
  /// Gets a value indicating whether the `DropDown` object is valid.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.valid?view=word-pia"/>
  public bool Valid { get; }
  /// <summary>
  /// Gets or sets the index number of the default list entry.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.default?view=word-pia"/>
  public int Default { get; set; }
  /// <summary>
  /// Gets or sets the index number of the selected list entry.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.value?view=word-pia"/>
  public int Value { get; set; }
  /// <summary>
  /// Gets the collection of list entries in the drop-down form field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.dropdown.listentries?view=word-pia"/>
  public IListEntries ListEntries { get; }

}
