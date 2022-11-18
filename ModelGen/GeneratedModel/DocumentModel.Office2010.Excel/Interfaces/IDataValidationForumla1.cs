namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidationForumla1 Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
public interface IDataValidationForumla1 // : DocumentFormat.OpenXml.Office2010.Excel.DataValidationFormulaType
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula { get ; set; }
  
}
