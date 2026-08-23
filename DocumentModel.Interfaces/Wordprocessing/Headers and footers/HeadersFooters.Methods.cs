namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headersfooters?view=word-pia"/>
public partial interface IHeadersFooters : IModelObject
{
  /// <summary>
  /// Returns a single header or footer from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="HeaderFooterIndex"/> value that identifies which header or footer to return.</param>
  /// <returns>The requested <see cref="IHeaderFooter"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headersfooters.get_item?view=word-pia"/>
  public IHeaderFooter Item(HeaderFooterType Index);
}
