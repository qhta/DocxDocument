namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LockingValues enumeration.
/// </summary>
public enum LockingKind
{
  /// <summary>
  /// SDT Cannot Be Deleted.
  /// </summary>
  SdtLocked,
  
  /// <summary>
  /// Contents Cannot Be Edited At Runtime.
  /// </summary>
  ContentLocked,
  
  /// <summary>
  /// No Locking.
  /// </summary>
  Unlocked,
  
  /// <summary>
  /// Contents Cannot Be Edited At Runtime And SDT Cannot Be Deleted.
  /// </summary>
  SdtContentLocked,
  
}
