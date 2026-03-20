namespace DocumentModel.Interop.Word;

public enum WdFindMatch
{
  wdMatchGraphic = unchecked((int)1),
  wdMatchCommentMark = unchecked((int)5),
  wdMatchTabCharacter = unchecked((int)9),
  wdMatchCaretCharacter = unchecked((int)11),
  wdMatchColumnBreak = unchecked((int)14),
  wdMatchField = unchecked((int)19),
  wdMatchNonbreakingHyphen = unchecked((int)30),
  wdMatchOptionalHyphen = unchecked((int)31),
  wdMatchNonbreakingSpace = unchecked((int)160),
  wdMatchEnDash = unchecked((int)8211),
  wdMatchEmDash = unchecked((int)8212),
  wdMatchManualLineBreak = unchecked((int)65551),
  wdMatchParagraphMark = unchecked((int)65551),
  wdMatchFootnoteMark = unchecked((int)65554),
  wdMatchEndnoteMark = unchecked((int)65555),
  wdMatchManualPageBreak = unchecked((int)65564),
  wdMatchAnyDigit = unchecked((int)65567),
  wdMatchSectionBreak = unchecked((int)65580),
  wdMatchAnyLetter = unchecked((int)65583),
  wdMatchAnyCharacter = unchecked((int)65599),
  wdMatchWhiteSpace = unchecked((int)65655)
}
