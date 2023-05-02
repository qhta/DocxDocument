namespace DocumentModel.Math;

/// <summary>
///   Specifies the properties of <see cref="Delimiter"/>, including the enclosing and separating characters, 
///   and the properties that affect the shape of the delimiters.
/// </summary>
public class DelimiterProperties: ModelElement
{
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  public string? BeginChar { get; set; }

  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  public string? SeparatorChar { get; set; }

  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  public string? EndChar { get; set; }

  /// <summary>
  ///   Allows separators to grow according to operator size.
  /// </summary>
  public bool? GrowOperators { get; set; }

  /// <summary>
  ///   Specifies if delimiter are vertically centered around the delimited expression,
  ///   or they are matched to the baseline of the expression.
  /// </summary>
  public ShapeDelimiterKind? Shape { get; set; }

  /// <summary>
  ///   Specifies formatting of delimiter object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}