namespace ModelGen;

/// <summary>
/// Number constaint. Specifies accepted range of values or number of elements.
/// </summary>
public record NumberConstraint : Constraint
{
  /// <summary>
  /// Minimum accepted value (long int).
  /// </summary>
  public long? MinInclusive { get; set; }

  /// <summary>
  /// Maximum accepted value (long int).
  /// </summary>
  public long? MaxInclusive { get; set; }

  /// <summary>
  /// Minimum unaccepted value (long int).
  /// </summary>
  public long? MinExclusive { get; set; }

  /// <summary>
  /// Maximum unaccepted value (long int).
  /// </summary>
  public long? MaxExclusive { get; set; }

}