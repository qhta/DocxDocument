namespace DocumentModel.Interop.Word;

/// <summary>
/// The ContentControlListEntries collection contains ContentControlListEntry objects that represent the items in a drop-down list or combo box content control.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries?view=word-pia"/>
public interface IContentControlListEntries : IInteropObject, IInteropCollection<ContentControlListEntry>
{


  #region methods

/// <summary>
  /// Adds an entry to the content control list.
  /// </summary>
  /// <param name="Text">The display text for the list entry.</param>
  /// <param name="Value">The underlying value for the list entry.</param>
  /// <param name="Index">The position at which to insert the entry.</param>
  /// <returns>The created <see cref="ContentControlListEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries.add?view=word-pia"/>
  public ContentControlListEntry Add(string Text, string Value, int Index);

  #endregion methods
}
