namespace DocumentModel.Interop.Word;

public enum WdMailMergeState
{
  wdNormalDocument = unchecked((int)0),
  wdMainDocumentOnly = unchecked((int)1),
  wdMainAndDataSource = unchecked((int)2),
  wdMainAndHeader = unchecked((int)3),
  wdMainAndSourceAndHeader = unchecked((int)4),
  wdDataSource = unchecked((int)5)
}
