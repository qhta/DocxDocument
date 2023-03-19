namespace DocumentModel.Math;

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