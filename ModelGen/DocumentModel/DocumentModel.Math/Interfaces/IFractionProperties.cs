namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public interface IFractionProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public FractionKind? FractionType { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
