namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Sparkline Class.
/// </summary>
public interface ISparkline // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public String? ReferenceSequence { get ; set; }
  
}
