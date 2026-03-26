namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata?view=word-pia"/>
public partial interface ChartData: InteropObject
{
  /// <summary>
  /// Activates the first window of the workbook associated with the chart.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata.activate?view=word-pia"/>
  public void Activate();
}
