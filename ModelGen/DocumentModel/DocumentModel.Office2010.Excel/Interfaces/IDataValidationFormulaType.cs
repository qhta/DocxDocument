namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidationFormulaType Class.
/// </summary>
public interface IDataValidationFormulaType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
}
