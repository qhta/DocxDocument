namespace ModelGen;

/// <summary>
/// String constaint applied to string property. Specifies accepted length of the string
/// or regular expression or XsdType for accepted string format.
/// </summary>
public record StringConstraint : Constraint
{
  /// <summary>
  /// Minimum accepted length of the string.
  /// </summary>
  public int? MinLength { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Maximum accepted length of the string.
  /// </summary>
  public int? MaxLength { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Fixed length of the string.
  /// </summary>
  public int? FixLength { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Regular expression that describes accepted string format.
  /// </summary>
  public string? Regex { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// XsdType that describes accepted string format. Only few XsdTypes are accepted.
  /// </summary>
  public XsdType? XsdType { [DebuggerStepThrough] get; set; }

}