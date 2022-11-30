namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Sparkline Class.
/// </summary>
public interface ISparkline // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public System.String? ReferenceSequence { get ; set; }
  
}
