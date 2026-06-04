namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active record in a mail merge result set.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergeactiverecord?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord))]
public enum MailMergeActiveRecordType
{
  /// <summary>
  /// The previous record in the data source.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdPreviousDataSourceRecord))]
  PreviousDataSourceRecord = -9,
  /// <summary>
  /// The next record in the data source.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdNextDataSourceRecord))]
  NextDataSourceRecord = -8,
  /// <summary>
  /// The last record in the data source.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdLastDataSourceRecord))]
  LastDataSourceRecord = -7,
  /// <summary>
  /// The first record in the data source.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdFirstDataSourceRecord))]
  FirstDataSourceRecord = -6,
  /// <summary>
  /// The last record in the result set.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdLastRecord))]
  LastRecord = -5,
  /// <summary>
  /// The first record in the result set.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdFirstRecord))]
  FirstRecord = -4,
  /// <summary>
  /// The previous record in the result set.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdPreviousRecord))]
  PreviousRecord = -3,
  /// <summary>
  /// The next record in the result set.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdNextRecord))]
  NextRecord = -2,
  /// <summary>
  /// No active record.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMailMergeActiveRecord.wdNoActiveRecord))]
  NoActiveRecord = -1
}
