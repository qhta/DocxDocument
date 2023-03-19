namespace DocumentModel.Math;

/// <summary>
///   Bar Properties.
/// </summary>
public class BarProperties: ModelElement
{
  /// <summary>
  ///   Position (Bar).
  /// </summary>
  public VerticalJustificationKind? Position { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}