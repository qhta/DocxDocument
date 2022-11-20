namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public class TableLook: ITableLook
{
  /// <summary>
  /// val
  /// </summary>
  public IHexBinaryValue? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NoHorizontalBand
  {
    get;
    set;
  }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NoVerticalBand
  {
    get;
    set;
  }
  
}
