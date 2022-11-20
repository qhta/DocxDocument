namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Sparkline Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IReferenceSequence))]
public interface ISparkline // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public IReferenceSequence? ReferenceSequence { get ; set; }
  
}
