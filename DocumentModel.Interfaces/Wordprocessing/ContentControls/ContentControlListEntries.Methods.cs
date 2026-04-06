namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries?view=word-pia"/>
public partial interface IContentControlListEntries: IModelObject
{
  /// <summary>
  /// Adds an entry to the content control list.
  /// </summary>
  /// <param name="Text">The display text for the list entry.</param>
  /// <param name="Value">The underlying value for the list entry.</param>
  /// <param name="Index">The position at which to insert the entry.</param>
  /// <returns>The created <see cref="IContentControlListEntry"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries.add?view=word-pia"/>
  public IContentControlListEntry Add(string Text, string Value, int Index);
}
