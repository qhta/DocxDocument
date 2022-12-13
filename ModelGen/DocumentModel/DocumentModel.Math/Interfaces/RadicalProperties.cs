namespace DocumentModel.Math;

/// <summary>
/// Radical Properties.
/// </summary>
public interface RadicalProperties
{
  /// <summary>
  /// Hide Degree.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideDegree { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
