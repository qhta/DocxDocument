namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents access to the linked or embedded data associated with a chart.
/// </summary>
public partial interface ChartData
{
  /// <summary>
  /// The workbook.
  /// </summary>
  public object Workbook { get; }

  /// <summary>
  /// The is linked.
  /// </summary>
  public bool IsLinked { get; }
}
