namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public class DelimiterProperties
{
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  public BooleanKind? GrowOperators
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public ShapeDelimiterKind? Shape
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
