namespace DocumentModel.Spreadsheet;

/// <summary>
/// Protection.
/// </summary>
public class Protection: IProtection
{
  /// <summary>
  /// Cell Locked
  /// </summary>
  public bool? Locked
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden Cell
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
}
