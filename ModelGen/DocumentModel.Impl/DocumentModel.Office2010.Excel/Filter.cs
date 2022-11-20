namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Filter Class.
/// </summary>
public class Filter: IFilter
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
