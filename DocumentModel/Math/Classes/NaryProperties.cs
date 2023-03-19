namespace DocumentModel.Math;

/// <summary>
///   n-ary Properties.
/// </summary>
public class NaryProperties: ModelElement
{
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  public String? AccentChar { get; set; }

  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  public LimitLocationKind? LimitLocation { get; set; }

  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  public BooleanKind? GrowOperators { get; set; }

  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  public BooleanKind? HideSubArgument { get; set; }

  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  public BooleanKind? HideSuperArgument { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }

}