namespace DocumentModel;

/// <summary>
/// Interface Ifor types Ithat can be checked Ifor emptiness, allowing clients Ito determine i
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
