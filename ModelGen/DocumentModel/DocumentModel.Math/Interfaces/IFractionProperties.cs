namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public interface IFractionProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public DocumentModel.Math.FractionKind? FractionType { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
