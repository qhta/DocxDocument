namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidationForumla2 Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
public class DataValidationForumla2: IDataValidationForumla2
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
