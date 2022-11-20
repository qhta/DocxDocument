namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Grouping.
/// </summary>
public interface IBarGrouping // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Bar Grouping Value
  /// </summary>
  public BarGroupingValues? Val { get ; set; }
  
}
