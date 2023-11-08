namespace ModelGen;

/// <summary>
/// Represents an element that can have an owner
/// </summary>
public interface IOwnedElement
{
  /// <summary>
  /// Owner of the element (can be of any object).
  /// </summary>
  public object? Owner { [DebuggerStepThrough] get; set; }
}