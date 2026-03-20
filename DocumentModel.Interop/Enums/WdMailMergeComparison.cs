namespace DocumentModel.Interop.Word;

public enum WdMailMergeComparison
{
  wdMergeIfEqual = unchecked((int)0),
  wdMergeIfNotEqual = unchecked((int)1),
  wdMergeIfLessThan = unchecked((int)2),
  wdMergeIfGreaterThan = unchecked((int)3),
  wdMergeIfLessThanOrEqual = unchecked((int)4),
  wdMergeIfGreaterThanOrEqual = unchecked((int)5),
  wdMergeIfIsBlank = unchecked((int)6),
  wdMergeIfIsNotBlank = unchecked((int)7)
}
