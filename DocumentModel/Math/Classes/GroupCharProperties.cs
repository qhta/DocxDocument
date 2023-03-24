namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Group-Character Properties.
/// </summary>
public class GroupCharProperties: ModelElement
{
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  public String? AccentChar { get; set; }

  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  public VerticalJustificationKind? Position { get; set; }

  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  public VerticalJustificationKind? VerticalJustification { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}