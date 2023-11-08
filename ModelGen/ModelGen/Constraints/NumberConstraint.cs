namespace ModelGen;

/// <summary>
/// Number constaint. Specifies accepted range of values or number of elements.
/// </summary>
public record NumberConstraint : Constraint
{
  /// <summary>
  /// Minimum accepted value (long int).
  /// </summary>
  public long? MinInclusive { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Maximum accepted value (long int).
  /// </summary>
  public long? MaxInclusive { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Minimum unaccepted value (long int).
  /// </summary>
  public long? MinExclusive { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Maximum unaccepted value (long int).
  /// </summary>
  public long? MaxExclusive { [DebuggerStepThrough] get; set; }

}