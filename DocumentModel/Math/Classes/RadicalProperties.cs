namespace DocumentModel.Math;

/// <summary>
///   Radical Properties.
/// </summary>
public class RadicalProperties: ModelElement
{
  /// <summary>
  ///   Hide Degree.
  /// </summary>
  public BooleanKind? HideDegree { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}