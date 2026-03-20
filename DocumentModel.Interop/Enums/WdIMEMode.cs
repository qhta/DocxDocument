namespace DocumentModel.Interop.Word;

public enum WdIMEMode
{
  wdIMEModeNoControl = unchecked((int)0),
  wdIMEModeOn = unchecked((int)1),
  wdIMEModeOff = unchecked((int)2),
  wdIMEModeHiragana = unchecked((int)4),
  wdIMEModeKatakana = unchecked((int)5),
  wdIMEModeKatakanaHalf = unchecked((int)6),
  wdIMEModeAlphaFull = unchecked((int)7),
  wdIMEModeAlpha = unchecked((int)8),
  wdIMEModeHangulFull = unchecked((int)9),
  wdIMEModeHangul = unchecked((int)10)
}
