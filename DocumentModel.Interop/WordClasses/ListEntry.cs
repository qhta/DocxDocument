namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an item in a drop-down form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentry?view=word-pia"/>
public partial class ListEntry : InteropObject
{
  /// <summary>
  /// Returns the position of the item in the list entries collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentry.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns or sets the text of the list entry item.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentry.name?view=word-pia"/>
  public string? Name { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentry.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}
