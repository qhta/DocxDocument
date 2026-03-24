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
  MergeInfoFromWord = unchecked((int)0),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  MergeInfoFromAccessDDE = unchecked((int)1),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  MergeInfoFromExcelDDE = unchecked((int)2),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  MergeInfoFromMSQueryDDE = unchecked((int)3),
  /// <summary>
  /// From an Open Database Connectivity (ODBC) connection.
  /// </summary>
  MergeInfoFromODBC = unchecked((int)4),
  /// <summary>
  /// From an Office Data Source Object (ODSO).
  /// </summary>
  MergeInfoFromODSO = unchecked((int)5),
  /// <summary>
  /// Specifies the data source for a mail merge operation.
  /// </summary>
  NoMergeInfo = unchecked((int)-1)
}
