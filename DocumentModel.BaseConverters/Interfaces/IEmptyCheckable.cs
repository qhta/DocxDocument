namespace DocumentModel;

/// <summary>
/// Interface for types that can be checked for emptiness, allowing clients to determine i
/// f the object is considered empty based on its internal state or content.
/// </summary>
public interface IEmptyCheckable
{
  /// <summary>
  /// Determines whether the current object is considered empty.
  /// </summary>
  /// <returns><c>true</c> if the object is empty; otherwise, <c>false</c>.</returns>
  public bool IsEmpty();
}
