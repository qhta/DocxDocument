namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ChartFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IChartFormat))]
public class ChartFormats: IChartFormats
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
