namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Level Groups.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroup))]
public class Groups: IGroups
{
  /// <summary>
  /// Level Group Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
