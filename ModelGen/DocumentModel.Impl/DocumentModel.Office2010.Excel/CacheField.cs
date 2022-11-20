namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CacheField Class.
/// </summary>
public class CacheField: ICacheField
{
  /// <summary>
  /// ignore, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Ignore
  {
    get;
    set;
  }
  
}
