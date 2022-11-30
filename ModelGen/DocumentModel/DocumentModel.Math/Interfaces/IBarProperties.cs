namespace DocumentModel.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public interface IBarProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? Position { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
