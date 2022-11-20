namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CalculatedMembers Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICalculatedMember))]
public class CalculatedMembers: ICalculatedMembers
{
  /// <summary>
  /// Calculated Members Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
