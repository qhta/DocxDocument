namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Equation Array Properties.
/// </summary>
public class EquationArrayProperties: ModelElement
{
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification { get; set; }

  /// <summary>
  ///   Maximum Distribution.
  /// </summary>
  public BooleanKind? MaxDistribution { get; set; }

  /// <summary>
  ///   Object Distribution.
  /// </summary>
  public BooleanKind? ObjectDistribution { get; set; }

  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public Int64? RowSpacingRule { get; set; }

  /// <summary>
  ///   Row Spacing (Equation Array).
  /// </summary>
  public UInt16? RowSpacing { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}