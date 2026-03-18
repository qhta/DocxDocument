namespace DocumentModel.Interop;

/// <summary>
/// Represents one of the readability statistics for a document or range.
/// </summary>
public interface ReadabilityStatistic : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The value.
  /// </summary>
  public float Value { get; }

}
