namespace DocumentModel.Spreadsheet;

/// <summary>
/// Main.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITopic))]
public class Main: IMain
{
  /// <summary>
  /// First String
  /// </summary>
  public string? First
  {
    get;
    set;
  }
  
}
