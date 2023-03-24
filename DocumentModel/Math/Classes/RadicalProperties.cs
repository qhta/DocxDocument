namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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