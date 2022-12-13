namespace DocumentModel.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public interface BarProperties
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? Position { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
