namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Delimiter Properties.
/// </summary>
public class DelimiterProperties: ModelElement
{
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  public String? BeginChar { get; set; }

  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  public String? SeparatorChar { get; set; }

  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  public String? EndChar { get; set; }

  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  public BooleanKind? GrowOperators { get; set; }

  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  public ShapeDelimiterKind? Shape { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}