namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of lock for a CoAuthLock object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlocktype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLockType")]
public enum LockType
{
  /// <summary>
  /// Reserved for future use.
  /// </summary>
  [InteropEnumValue("wdLockNone")]
  None = 0,
  /// <summary>
  /// Specifies a reservation lock. A reservation lock is explicitly created by a user through the Block Authors
  /// button on the Review tab in Word 2010.
  /// </summary>
  [InteropEnumValue("wdLockReservation")]
  Reservation = 1,
  /// <summary>
  /// Specifies an ephemeral lock that Word 2010 implicitly places on a range when a user begins editing a range in
  /// a document with co-authoring enabled.
  /// </summary>
  [InteropEnumValue("wdLockEphemeral")]
  Ephemeral = 2,
  /// <summary>
  /// Specifies a placeholder lock. A placeholder lock indicates that another user has removed their lock from the
  /// range, but the current user has not updated their view of the document by saving.
  /// </summary>
  [InteropEnumValue("wdLockChanged")]
  Changed = 3
}
