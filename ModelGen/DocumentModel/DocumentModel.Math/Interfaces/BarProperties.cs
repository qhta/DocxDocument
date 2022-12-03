namespace DocumentModel.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public interface BarProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public VerticalJustificationKind? Position { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
