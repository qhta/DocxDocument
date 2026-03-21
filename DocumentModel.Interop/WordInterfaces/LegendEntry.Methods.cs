namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry?view=word-pia"/>
public partial interface LegendEntry
{
  /// <summary>
  /// Deletes the legend entry from the chart.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentry.delete?view=word-pia"/>
  public void Delete();
}
