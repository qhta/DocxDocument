namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of lock for a CoAuthLock object.
/// </summary>
public enum WdLockType
{
  /// <summary>
  /// Reserved for future use. wdLockReservation1 Specifies a reservation lock. A reservation lock is explicitly
  /// created by a user through the Block Authors button on the Review tab in Word 2010. wdLockEphemeral2 Specifies
  /// an ephemeral lock that
  /// </summary>
  wdLockNone = unchecked((int)0),
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  wdLockReservation = unchecked((int)1),
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  wdLockEphemeral = unchecked((int)2),
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  wdLockChanged = unchecked((int)3)
}
