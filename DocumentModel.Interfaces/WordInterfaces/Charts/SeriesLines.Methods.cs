namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines?view=word-pia"/>
public partial interface SeriesLines: InteropObject
{
  /// <summary>
  /// Selects and returns an object based on the current context or criteria.
  /// </summary>
  /// <returns>An object representing the selected item. The specific type and meaning of the returned object depend on the
  /// implementation.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.serieslines.select?view=word-pia"/>
  public object Select();
}
