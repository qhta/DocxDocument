namespace DocumentModel.Interop.Word;

public enum WdCompatibilityMode
{
  wdWord2003 = unchecked((int)11),
  wdWord2007 = unchecked((int)12),
  wdWord2010 = unchecked((int)14),
  wdWord2013 = unchecked((int)15),
  wdCurrent = unchecked((int)65535)
}
