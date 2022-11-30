namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the IgnoredError Class.
/// </summary>
public interface IIgnoredError // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// evalError, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? EvalError { get ; set; }
  
  /// <summary>
  /// twoDigitTextYear, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? TwoDigitTextYear { get ; set; }
  
  /// <summary>
  /// numberStoredAsText, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NumberStoredAsText { get ; set; }
  
  /// <summary>
  /// formula, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Formula { get ; set; }
  
  /// <summary>
  /// formulaRange, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FormulaRange { get ; set; }
  
  /// <summary>
  /// unlockedFormula, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? UnlockedFormula { get ; set; }
  
  /// <summary>
  /// emptyCellReference, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? EmptyCellReference { get ; set; }
  
  /// <summary>
  /// listDataValidation, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ListDataValidation { get ; set; }
  
  /// <summary>
  /// calculatedColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? CalculatedColumn { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public System.String? ReferenceSequence { get ; set; }
  
}
