namespace DocumentModel;

/// <summary>
/// Defines a contract for objects that provide a name identifier.  
/// </summary>
/// <remarks>Implementations of this interface should return a meaningful name that uniquely identifies the object
/// within its context. The returned name may be null if the object does not have an assigned name.</remarks>
public interface INamedObject
{
  /// <summary>
  /// A name.
  /// </summary>
  /// <returns></returns>
  public string? GetName();
}