namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Grouping.
/// </summary>
public interface IGrouping // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Grouping Value
  /// </summary>
  public GroupingValues? Val { get ; set; }
  
}
