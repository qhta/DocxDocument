namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle?view=word-pia"/>
public partial interface ChartTitle
{
  /// <summary>
  /// Returns a ChartCharacters object that represents a range of characters in the chart title text.
  /// </summary>
  /// <param name="Start">The starting character position.</param>
  /// <param name="Length">The number of characters to return.</param>
  /// <returns>The requested <see cref="ChartCharacters"/> range.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.get_characters?view=word-pia"/>
  public ChartCharacters get_Characters(object Start, object Length);

  /// <summary>
  /// Deletes the chart title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.delete?view=word-pia"/>
  public void Delete();
}
