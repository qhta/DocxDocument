namespace DocumentModel.Spreadsheet;

/// <summary>
/// DDE Name Values.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IValue))]
public class Values: IValues
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
