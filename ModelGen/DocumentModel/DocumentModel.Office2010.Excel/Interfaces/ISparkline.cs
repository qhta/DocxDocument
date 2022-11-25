namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Sparkline Class.
/// </summary>
public interface ISparkline // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Formula { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ReferenceSequence { get ; set; }
  
}
