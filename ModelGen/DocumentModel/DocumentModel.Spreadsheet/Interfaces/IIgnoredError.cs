namespace DocumentModel.Spreadsheet;

/// <summary>
/// Ignored Error.
/// </summary>
public interface IIgnoredError // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Sequence of References
  /// </summary>
  public List<string>? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// Evaluation Error
  /// </summary>
  public bool? EvalError { get ; set; }
  
  /// <summary>
  /// Two Digit Text Year
  /// </summary>
  public bool? TwoDigitTextYear { get ; set; }
  
  /// <summary>
  /// Number Stored As Text
  /// </summary>
  public bool? NumberStoredAsText { get ; set; }
  
  /// <summary>
  /// Formula
  /// </summary>
  public bool? Formula { get ; set; }
  
  /// <summary>
  /// Formula Range
  /// </summary>
  public bool? FormulaRange { get ; set; }
  
  /// <summary>
  /// Unlocked Formula
  /// </summary>
  public bool? UnlockedFormula { get ; set; }
  
  /// <summary>
  /// Empty Cell Reference
  /// </summary>
  public bool? EmptyCellReference { get ; set; }
  
  /// <summary>
  /// List Data Validation
  /// </summary>
  public bool? ListDataValidation { get ; set; }
  
  /// <summary>
  /// Calculated Column
  /// </summary>
  public bool? CalculatedColumn { get ; set; }
  
}
