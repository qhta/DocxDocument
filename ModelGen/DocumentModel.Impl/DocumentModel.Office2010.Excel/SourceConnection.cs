namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SourceConnection Class.
/// </summary>
public class SourceConnection: ISourceConnection
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
}
