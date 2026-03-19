namespace DocumentModel.Interop.Word;

public partial interface HeadersFooters
{
  /// <summary>
  /// Returns a single header or footer from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="WdHeaderFooterIndex"/> value that identifies which header or footer to return.</param>
  /// <returns>The requested <see cref="HeaderFooter"/> object.</returns>
  public HeaderFooter get_Item(WdHeaderFooterIndex Index);
}
