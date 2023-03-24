namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Fraction Properties.
/// </summary>
public class FractionProperties: ModelElement
{
  /// <summary>
  ///   Fraction type.
  /// </summary>
  public FractionKind? FractionType { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}