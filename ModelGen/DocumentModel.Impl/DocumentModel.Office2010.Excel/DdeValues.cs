namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DdeValues Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IValue))]
public class DdeValues: IDdeValues
{
  /// <summary>
  /// Rows
  /// </summary>
  public uint? Rows
  {
    get;
    set;
  }
  
  /// <summary>
  /// Columns
  /// </summary>
  public uint? Columns
  {
    get;
    set;
  }
  
}
