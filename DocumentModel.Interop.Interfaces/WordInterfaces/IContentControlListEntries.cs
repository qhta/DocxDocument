namespace DocumentModel.Interop.Word;

/// <summary>
/// The ContentControlListEntries collection contains ContentControlListEntry objects that represent the items in a drop-down list or combo box content control.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries?view=word-pia"/>
public interface IContentControlListEntries : IInteropObject, IInteropCollection<IContentControlListEntry>
{


  #region methods

/// <summary>
  /// Adds an entry to the content control list.
  /// </summary>
  /// <param name="text">The display text for the list entry.</param>
  /// <param name="value">The underlying value for the list entry.</param>
  /// <param name="index">The position at which to insert the entry.</param>
  /// <returns>The created <see cref="IContentControlListEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries.add?view=word-pia"/>
  public IContentControlListEntry Add(string text, string value, int index);

  #endregion methods
}
