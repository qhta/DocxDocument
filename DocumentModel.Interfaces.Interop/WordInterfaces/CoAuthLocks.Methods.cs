namespace DocumentModel.Interop;

public partial interface CoAuthLocks
{
  /// <summary>
  /// Adds a co-authoring lock for the specified range and lock type.
  /// </summary>
  /// <param name="Range">The range to lock.</param>
  /// <param name="Type">The lock type to apply.</param>
  /// <returns>The created <see cref="CoAuthLock"/> object.</returns>
  public CoAuthLock Add(object Range, WdLockType Type);

  /// <summary>
  /// Removes ephemeral co-authoring locks.
  /// </summary>
  public void RemoveEphemeralLocks();
}
