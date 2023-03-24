namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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