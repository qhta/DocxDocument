namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IgnoredError Class.
/// </summary>
public interface IgnoredError // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// evalError, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EvalError { get ; set; }
  
  /// <summary>
  /// twoDigitTextYear, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? TwoDigitTextYear { get ; set; }
  
  /// <summary>
  /// numberStoredAsText, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NumberStoredAsText { get ; set; }
  
  /// <summary>
  /// formula, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Formula { get ; set; }
  
  /// <summary>
  /// formulaRange, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FormulaRange { get ; set; }
  
  /// <summary>
  /// unlockedFormula, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? UnlockedFormula { get ; set; }
  
  /// <summary>
  /// emptyCellReference, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EmptyCellReference { get ; set; }
  
  /// <summary>
  /// listDataValidation, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ListDataValidation { get ; set; }
  
  /// <summary>
  /// calculatedColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? CalculatedColumn { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public String? ReferenceSequence { get ; set; }
  
}
