namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public interface FractionProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public FractionKind? FractionType { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
