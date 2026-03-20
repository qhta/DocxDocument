namespace DocumentModel.Interop.Word;

public enum WdProtectionType
{
  wdAllowOnlyRevisions = unchecked((int)0),
  wdAllowOnlyComments = unchecked((int)1),
  wdAllowOnlyFormFields = unchecked((int)2),
  wdAllowOnlyReading = unchecked((int)3),
  wdNoProtection = unchecked((int)-1)
}
