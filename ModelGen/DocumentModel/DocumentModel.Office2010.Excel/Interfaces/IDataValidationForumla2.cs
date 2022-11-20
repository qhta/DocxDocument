namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidationForumla2 Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
public interface IDataValidationForumla2 // : DocumentFormat.OpenXml.Office2010.Excel.DataValidationFormulaType
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula { get ; set; }
  
}
