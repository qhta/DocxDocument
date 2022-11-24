namespace DocumentModel.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public interface IBarProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public IPosition? Position { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
