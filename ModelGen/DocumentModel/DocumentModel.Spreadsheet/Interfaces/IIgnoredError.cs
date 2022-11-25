namespace DocumentModel.Spreadsheet;

/// <summary>
/// Ignored Error.
/// </summary>
public interface IIgnoredError // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Sequence of References
  /// </summary>
  public System.Collections.Generic.List<System.String>? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// Evaluation Error
  /// </summary>
  public System.Boolean? EvalError { get ; set; }
  
  /// <summary>
  /// Two Digit Text Year
  /// </summary>
  public System.Boolean? TwoDigitTextYear { get ; set; }
  
  /// <summary>
  /// Number Stored As Text
  /// </summary>
  public System.Boolean? NumberStoredAsText { get ; set; }
  
  /// <summary>
  /// Formula
  /// </summary>
  public System.Boolean? Formula { get ; set; }
  
  /// <summary>
  /// Formula Range
  /// </summary>
  public System.Boolean? FormulaRange { get ; set; }
  
  /// <summary>
  /// Unlocked Formula
  /// </summary>
  public System.Boolean? UnlockedFormula { get ; set; }
  
  /// <summary>
  /// Empty Cell Reference
  /// </summary>
  public System.Boolean? EmptyCellReference { get ; set; }
  
  /// <summary>
  /// List Data Validation
  /// </summary>
  public System.Boolean? ListDataValidation { get ; set; }
  
  /// <summary>
  /// Calculated Column
  /// </summary>
  public System.Boolean? CalculatedColumn { get ; set; }
  
}
