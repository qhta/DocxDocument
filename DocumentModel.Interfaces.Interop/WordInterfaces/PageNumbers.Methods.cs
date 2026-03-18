namespace DocumentModel.Interop;

public partial interface PageNumbers
{
  /// <summary>
  /// Adds a page number to the document with the specified alignment and starting page option.
  /// </summary>
  /// <param name="PageNumberAlignment">Specifies the alignment of the page number. The value determines how the page number is positioned on the page.</param>
  /// <param name="FirstPage">Indicates whether the page number should be added to the first page. Set to <see langword="true"/> to include the
  /// page number on the first page; otherwise, <see langword="false"/>.</param>
  /// <returns>A <see cref="PageNumber"/> object representing the added page number.</returns>
  public PageNumber Add(WdPageNumberAlignment PageNumberAlignment, bool FirstPage);
}
