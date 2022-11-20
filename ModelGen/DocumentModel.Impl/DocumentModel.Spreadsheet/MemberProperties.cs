namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberProperty))]
public class MemberProperties: IMemberProperties
{
  /// <summary>
  /// OLAP Member Properties Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
