namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Grouping.
/// </summary>
public interface IGrouping // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Grouping Value
  /// </summary>
  public GroupingValues? Val { get ; set; }
  
}
