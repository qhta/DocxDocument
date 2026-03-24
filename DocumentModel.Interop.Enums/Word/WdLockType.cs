namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of lock for a CoAuthLock object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlocktype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLockType
{
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  Reservation = 1,
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  Ephemeral = 2,
  /// <summary>
  /// Specifies the type of lock for a CoAuthLock object.
  /// </summary>
  Changed = 3
}
