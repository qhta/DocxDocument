namespace DocumentModel.Math;

/// <summary>
/// Radical Properties.
/// </summary>
public interface IRadicalProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hide Degree.
  /// </summary>
  public BooleanKind? HideDegree { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
