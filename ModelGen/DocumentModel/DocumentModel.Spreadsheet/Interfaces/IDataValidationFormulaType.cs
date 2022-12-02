namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataValidationFormulaType Class.
/// </summary>
public interface IDataValidationFormulaType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
}
