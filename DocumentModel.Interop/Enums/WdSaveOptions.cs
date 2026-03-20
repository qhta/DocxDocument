namespace DocumentModel.Interop.Word;

public enum WdSaveOptions
{
  wdDoNotSaveChanges = unchecked((int)0),
  wdPromptToSaveChanges = unchecked((int)-2),
  wdSaveChanges = unchecked((int)-1)
}
