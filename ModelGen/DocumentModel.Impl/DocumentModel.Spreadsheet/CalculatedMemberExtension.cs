namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICalculatedMember))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ICalculatedMember))]
public class CalculatedMemberExtension: ICalculatedMemberExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
