namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active record in a mail merge result set.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergeactiverecord?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMailMergeActiveRecord")]
public enum MailMergeActiveRecordType
{
  /// <summary>
  /// The previous record in the data source.
  /// </summary>
  [InteropEnumValue("wdPreviousDataSourceRecord")]
  PreviousDataSourceRecord = -9,
  /// <summary>
  /// The next record in the data source.
  /// </summary>
  [InteropEnumValue("wdNextDataSourceRecord")]
  NextDataSourceRecord = -8,
  /// <summary>
  /// The last record in the data source.
  /// </summary>
  [InteropEnumValue("wdLastDataSourceRecord")]
  LastDataSourceRecord = -7,
  /// <summary>
  /// The first record in the data source.
  /// </summary>
  [InteropEnumValue("wdFirstDataSourceRecord")]
  FirstDataSourceRecord = -6,
  /// <summary>
  /// The last record in the result set.
  /// </summary>
  [InteropEnumValue("wdLastRecord")]
  LastRecord = -5,
  /// <summary>
  /// The first record in the result set.
  /// </summary>
  [InteropEnumValue("wdFirstRecord")]
  FirstRecord = -4,
  /// <summary>
  /// The previous record in the result set.
  /// </summary>
  [InteropEnumValue("wdPreviousRecord")]
  PreviousRecord = -3,
  /// <summary>
  /// The next record in the result set.
  /// </summary>
  [InteropEnumValue("wdNextRecord")]
  NextRecord = -2,
  /// <summary>
  /// No active record.
  /// </summary>
  [InteropEnumValue("wdNoActiveRecord")]
  NoActiveRecord = -1
}
