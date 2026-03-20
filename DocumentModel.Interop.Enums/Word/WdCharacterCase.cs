namespace DocumentModel.Interop.Word;

public enum WdCharacterCase
{
  wdLowerCase = unchecked((int)0),
  wdUpperCase = unchecked((int)1),
  wdTitleWord = unchecked((int)2),
  wdTitleSentence = unchecked((int)4),
  wdToggleCase = unchecked((int)5),
  wdHalfWidth = unchecked((int)6),
  wdFullWidth = unchecked((int)7),
  wdKatakana = unchecked((int)8),
  wdHiragana = unchecked((int)9),
  wdNextCase = unchecked((int)-1)
}
