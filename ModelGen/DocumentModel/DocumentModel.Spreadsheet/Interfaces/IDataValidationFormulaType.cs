namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataValidationFormulaType Class.
/// </summary>
public interface IDataValidationFormulaType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
}
