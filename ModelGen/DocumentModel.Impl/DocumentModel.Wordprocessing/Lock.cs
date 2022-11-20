namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public class Lock: ILock
{
  /// <summary>
  /// Locking Type
  /// </summary>
  public LockingValues? Val
  {
    get;
    set;
  }
  
}
