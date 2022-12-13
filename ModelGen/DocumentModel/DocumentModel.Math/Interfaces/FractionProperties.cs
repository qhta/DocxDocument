namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public interface FractionProperties
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public DocumentModel.Math.FractionKind? FractionType { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
