namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents access to the linked or embedded data associated with a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata?view=word-pia"/>
public partial class ChartData
{
  /// <summary>
  /// Gets the workbook that contains the chart data.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata.workbook?view=word-pia"/>
  public object Workbook { get; set; }

  /// <summary>
  /// Gets a value indicating whether the chart data is linked to an external workbook.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata.islinked?view=word-pia"/>
  public bool IsLinked { get; set; }


  #region methods

/// <summary>
  /// Activates the first window of the workbook associated with the chart.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata.activate?view=word-pia"/>
  public void Activate() { throw new NotImplementedException(); }

  #endregion methods
}
