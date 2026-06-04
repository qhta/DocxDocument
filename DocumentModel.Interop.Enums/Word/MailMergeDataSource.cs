namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source for a mail merge operation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergedatasource?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailMergeDataSource")]
public enum MailMergeDataSourceType
{
  /// <summary>
  /// From Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdMergeInfoFromWord")]
  MergeInfoFromWord = 0,
  /// <summary>
  /// From Microsoft Access using Dynamic Data Exchange (DDE).
  /// </summary>
  [WordInteropEnumValue("wdMergeInfoFromAccessDDE")]
  MergeInfoFromAccessDDE = 1,
  /// <summary>
  /// From Microsoft Excel using DDE.
  /// </summary>
  [WordInteropEnumValue("wdMergeInfoFromExcelDDE")]
  MergeInfoFromExcelDDE = 2,
  /// <summary>
  /// From MSQuery using DDE.
  /// </summary>
  [WordInteropEnumValue("wdMergeInfoFromMSQueryDDE")]
  MergeInfoFromMSQueryDDE = 3,
  /// <summary>
  /// From an Open Database Connectivity (ODBC) connection.
  /// </summary>
  [WordInteropEnumValue("wdMergeInfoFromODBC")]
  MergeInfoFromODBC = 4,
  /// <summary>
  /// From an Office Data Source Object (ODSO).
  /// </summary>
  [WordInteropEnumValue("wdMergeInfoFromODSO")]
  MergeInfoFromODSO = 5,
  /// <summary>
  /// No merge information provided.
  /// </summary>
  [WordInteropEnumValue("wdNoMergeInfo")]
  NoMergeInfo = -1
}
