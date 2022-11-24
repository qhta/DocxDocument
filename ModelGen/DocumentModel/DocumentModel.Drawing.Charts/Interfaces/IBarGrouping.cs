namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Grouping.
/// </summary>
public interface IBarGrouping // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Bar Grouping Value
  /// </summary>
  public BarGroupingValues? Val { get ; set; }
  
}
