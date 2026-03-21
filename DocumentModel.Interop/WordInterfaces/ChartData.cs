namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents access to the linked or embedded data associated with a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata?view=word-pia"/>
public partial interface ChartData
{
  /// <summary>
  /// The workbook.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata.workbook?view=word-pia"/>
  public object Workbook { get; }

  /// <summary>
  /// The is linked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartdata.islinked?view=word-pia"/>
  public bool IsLinked { get; }
}
