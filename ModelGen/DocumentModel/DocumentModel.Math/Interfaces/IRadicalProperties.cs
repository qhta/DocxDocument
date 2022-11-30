namespace DocumentModel.Math;

/// <summary>
/// Radical Properties.
/// </summary>
public interface IRadicalProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hide Degree.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideDegree { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
