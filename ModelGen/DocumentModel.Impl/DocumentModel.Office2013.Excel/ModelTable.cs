namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the ModelTable Class.
/// </summary>
public class ModelTable: IModelTable
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// connection, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Connection
  {
    get;
    set;
  }
  
}
