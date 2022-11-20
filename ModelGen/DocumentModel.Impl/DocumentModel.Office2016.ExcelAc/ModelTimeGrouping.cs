namespace DocumentModel.Office2016.ExcelAc;

/// <summary>
/// Defines the ModelTimeGrouping Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.ExcelAc.ICalculatedTimeColumn))]
public class ModelTimeGrouping: IModelTimeGrouping
{
  /// <summary>
  /// tableName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? TableName
  {
    get;
    set;
  }
  
  /// <summary>
  /// columnName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? ColumnName
  {
    get;
    set;
  }
  
  /// <summary>
  /// columnId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? ColumnId
  {
    get;
    set;
  }
  
}
