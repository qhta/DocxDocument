namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source for a mail merge operation.
/// </summary>
public enum WdMailMergeDataSource
{
  /// <summary>
  /// From Microsoft Word. wdMergeInfoFromAccessDDE1 From Microsoft Access using Dynamic Data Exchange (DDE).
  /// wdMergeInfoFromExcelDDE2 From Microsoft Excel using DDE. wdMergeInfoFromMSQueryDDE3 From MSQuery using DDE.
  /// </summary>
  wdMergeInfoFromWord = unchecked((int)0),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  wdMergeInfoFromAccessDDE = unchecked((int)1),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  wdMergeInfoFromExcelDDE = unchecked((int)2),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  wdMergeInfoFromMSQueryDDE = unchecked((int)3),
  /// <summary>
  /// From an Open Database Connectivity (ODBC) connection.
  /// </summary>
  wdMergeInfoFromODBC = unchecked((int)4),
  /// <summary>
  /// From an Office Data Source Object (ODSO).
  /// </summary>
  wdMergeInfoFromODSO = unchecked((int)5),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  wdNoMergeInfo = unchecked((int)-1)
}
