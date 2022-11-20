namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Left Margin Default.
/// </summary>
public class TableCellLeftMargin: ITableCellLeftMargin
{
  /// <summary>
  /// w
  /// </summary>
  public short? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthValues? Type
  {
    get;
    set;
  }
  
}
