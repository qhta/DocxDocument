namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the IgnoredError Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IReferenceSequence))]
public interface IIgnoredError // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// evalError, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? EvalError { get ; set; }
  
  /// <summary>
  /// twoDigitTextYear, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? TwoDigitTextYear { get ; set; }
  
  /// <summary>
  /// numberStoredAsText, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NumberStoredAsText { get ; set; }
  
  /// <summary>
  /// formula, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Formula { get ; set; }
  
  /// <summary>
  /// formulaRange, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FormulaRange { get ; set; }
  
  /// <summary>
  /// unlockedFormula, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? UnlockedFormula { get ; set; }
  
  /// <summary>
  /// emptyCellReference, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? EmptyCellReference { get ; set; }
  
  /// <summary>
  /// listDataValidation, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ListDataValidation { get ; set; }
  
  /// <summary>
  /// calculatedColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? CalculatedColumn { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public IReferenceSequence? ReferenceSequence { get ; set; }
  
}
