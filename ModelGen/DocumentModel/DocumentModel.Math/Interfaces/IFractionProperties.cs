namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public interface IFractionProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public DocumentModel.Math.FractionTypeKind? FractionType { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ControlProperties { get ; set; }
  
}
