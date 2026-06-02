namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of HeaderFooter objects that represent the headers or footers in the specified section of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headersfooters?view=word-pia"/>
public interface IHeadersFooters : IInteropObject, IInteropCollection<HeaderFooter>
{


  #region methods

/// <summary>
  /// Returns a single header or footer from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="HeaderFooterIndex"/> value that identifies which header or footer to return.</param>
  /// <returns>The requested <see cref="HeaderFooter"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headersfooters.get_item?view=word-pia"/>
  public HeaderFooter Item(HeaderFooterIndex Index);

  #endregion methods
}
