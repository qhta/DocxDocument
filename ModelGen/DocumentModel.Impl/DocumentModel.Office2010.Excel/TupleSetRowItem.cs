namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TupleSetRowItem Class.
/// </summary>
public class TupleSetRowItem: ITupleSetRowItem
{
  /// <summary>
  /// u, this property is only available in Office 2010 and later.
  /// </summary>
  public string? UniqueName
  {
    get;
    set;
  }
  
  /// <summary>
  /// d, this property is only available in Office 2010 and later.
  /// </summary>
  public string? DisplayName
  {
    get;
    set;
  }
  
}
