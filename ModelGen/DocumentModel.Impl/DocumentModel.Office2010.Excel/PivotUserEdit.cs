namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotUserEdit Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotEditValue))]
public class PivotUserEdit: IPivotUserEdit
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// PivotEditValue.
  /// </summary>
  public IPivotEditValue? PivotEditValue
  {
    get;
    set;
  }
  
}
