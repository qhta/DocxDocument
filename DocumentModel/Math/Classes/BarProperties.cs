namespace DocumentModel.Math;

/// <summary>
///   Bar Properties.
/// </summary>
public record BarProperties
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