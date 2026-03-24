namespace DocumentModel;
/// <summary>
/// Defines a contract for objects that provide a name identifier.  
/// </summary>
/// <remarks>Implementations of This class should return a meaningful name that uniquely identifies the object
/// within its context. The returned name may be null if the object does not have an assigned name.</remarks>
public interface INamedObject
{
  /// <summary>
  /// A name.
  /// </summary>
  /// <returns></returns>
  public string? Name { get; set; }

  /// <summary>
  /// Event raised when the Name property changes, providing the old and new names of the object.
  /// </summary>
  public event EventHandler<NameChangedEventArgs>? NameChanged;
}

/// <summary>
/// Event arguments for the NameChanged event, containing the old and new names of the object.  
/// </summary>
/// <param name="oldName">Old object name (optional)</param>
/// <param name="newName">New object name (optional)</param>
public class NameChangedEventArgs(string? oldName, string? newName) : EventArgs
{
  /// <summary>
  /// Old name of the object before the change.
  /// This value can be null if the object did not have a name assigned before or if the old name is not available.
  /// </summary>
  public string? OldName { get; } = oldName;
  /// <summary>
  /// New name of the object after the change.
  /// This value can be null if the object does not have a name assigned or if the new name is not available.
  /// </summary>
  public string? NewName { get; } = newName;
}