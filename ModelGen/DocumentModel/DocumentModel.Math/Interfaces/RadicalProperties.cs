namespace DocumentModel.Math;

/// <summary>
/// Radical Properties.
/// </summary>
public interface RadicalProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Hide Degree.
  /// </summary>
  public BooleanKind? HideDegree { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
