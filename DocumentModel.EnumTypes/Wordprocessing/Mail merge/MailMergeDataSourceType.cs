namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the data source for a mail merge operation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergedatasource?view=office-pia` for Office interop details.
/// </remarks>
public enum MailMergeDataSourceType
{
  /// <summary>
  /// From Microsoft Word.
  /// </summary>
  MergeInfoFromWord = 0,
  /// <summary>
  /// From Microsoft Access using Dynamic Data Exchange (DDE).
  /// </summary>
  MergeInfoFromAccessDDE = 1,
  /// <summary>
  /// From Microsoft Excel using DDE.
  /// </summary>
  MergeInfoFromExcelDDE = 2,
  /// <summary>
  /// From MSQuery using DDE.
  /// </summary>
  MergeInfoFromMSQueryDDE = 3,
  /// <summary>
  /// From an Open Database Connectivity (ODBC) connection.
  /// </summary>
  MergeInfoFromODBC = 4,
  /// <summary>
  /// From an Office Data Source Object (ODSO).
  /// </summary>
  MergeInfoFromODSO = 5,
  /// <summary>
  /// No merge information provided.
  /// </summary>
  NoMergeInfo = -1
}
