namespace DocumentModel;

/// <summary>
/// Represents a collection of elements that  have a maximum count limit.
/// </summary>
public interface ILimitedCollection
{
  /// <summary>
  /// Gets the maximum number of elements that the collection can contain.
  /// </summary>
  public int MaxCount { get; }
  
}