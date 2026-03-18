namespace DocumentModel.Interop;

public partial interface ContentControlListEntries
{
  /// <summary>
  /// Adds an entry to the content control list.
  /// </summary>
  /// <param name="Text">The display text for the list entry.</param>
  /// <param name="Value">The underlying value for the list entry.</param>
  /// <param name="Index">The position at which to insert the entry.</param>
  /// <returns>The created <see cref="ContentControlListEntry"/> object.</returns>
  public ContentControlListEntry Add(string Text, string Value, int Index);
}
