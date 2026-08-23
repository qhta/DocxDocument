namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers?view=word-pia"/>
public partial interface IPageNumbers : IModelObject
{
  /// <summary>
  /// Adds a page number to the document with the specified alignment and starting page option.
  /// </summary>
  /// <param name="PageNumberAlignment">Specifies the alignment of the page number. The value determines how the page number is positioned on the page.</param>
  /// <param name="FirstPage">Indicates whether the page number should be added to the first page. Set to <see langword="true"/> to include the
  /// page number on the first page; otherwise, <see langword="false"/>.</param>
  /// <returns>A <see cref="IPageNumber"/> object representing the added page number.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.add?view=word-pia"/>
  public IPageNumber Add(PageNumberAlignment PageNumberAlignment, bool FirstPage);
}
