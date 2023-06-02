namespace ModelGen;

/// <summary>
/// Status of acceptance of the processed element.
/// </summary>
public enum ARS
{
  /// <summary>
  /// Unspecified
  /// </summary>
  None = 0,
  /// <summary>
  /// The element is accepted for further processing.
  /// </summary>
  Accepted = 1,
  /// <summary>
  /// The element is rejected from further processing.
  /// </summary>
  Rejected = 2,
}
