namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidationForumla1 Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
public class DataValidationForumla1: IDataValidationForumla1
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula
  {
    get;
    set;
  }
  
}
