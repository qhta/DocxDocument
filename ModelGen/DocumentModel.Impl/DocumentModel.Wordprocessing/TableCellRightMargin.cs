namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell Right Margin Default.
/// </summary>
public class TableCellRightMargin: ITableCellRightMargin
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
