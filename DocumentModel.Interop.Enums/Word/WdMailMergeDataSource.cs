namespace DocumentModel.Interop.Word;

public enum WdMailMergeDataSource
{
  wdMergeInfoFromWord = unchecked((int)0),
  wdMergeInfoFromAccessDDE = unchecked((int)1),
  wdMergeInfoFromExcelDDE = unchecked((int)2),
  wdMergeInfoFromMSQueryDDE = unchecked((int)3),
  wdMergeInfoFromODBC = unchecked((int)4),
  wdMergeInfoFromODSO = unchecked((int)5),
  wdNoMergeInfo = unchecked((int)-1)
}
