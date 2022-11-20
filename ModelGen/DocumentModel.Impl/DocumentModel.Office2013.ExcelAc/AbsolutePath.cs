namespace DocumentModel.Office2013.ExcelAc;

/// <summary>
/// Defines the AbsolutePath Class.
/// </summary>
public class AbsolutePath: IAbsolutePath
{
  /// <summary>
  /// url, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Url
  {
    get;
    set;
  }
  
}
