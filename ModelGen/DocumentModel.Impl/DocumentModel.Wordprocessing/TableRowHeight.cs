namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public class TableRowHeight: ITableRowHeight
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public HeightRuleValues? HeightType
  {
    get;
    set;
  }
  
}
