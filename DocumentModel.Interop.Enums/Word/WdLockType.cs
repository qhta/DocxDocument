namespace DocumentModel.Interop.Word;

public enum WdLockType
{
  wdLockNone = unchecked((int)0),
  wdLockReservation = unchecked((int)1),
  wdLockEphemeral = unchecked((int)2),
  wdLockChanged = unchecked((int)3)
}
