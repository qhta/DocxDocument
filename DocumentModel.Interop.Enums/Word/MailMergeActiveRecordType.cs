namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active record in a mail merge result set.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergeactiverecord?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailMergeActiveRecord")]
public enum MailMergeActiveRecordType
{
  /// <summary>
  /// The previous record in the data source.
  /// </summary>
  [WordInteropEnumValue("wdPreviousDataSourceRecord")]
  PreviousDataSourceRecord = -9,
  /// <summary>
  /// The next record in the data source.
  /// </summary>
  [WordInteropEnumValue("wdNextDataSourceRecord")]
  NextDataSourceRecord = -8,
  /// <summary>
  /// The last record in the data source.
  /// </summary>
  [WordInteropEnumValue("wdLastDataSourceRecord")]
  LastDataSourceRecord = -7,
  /// <summary>
  /// The first record in the data source.
  /// </summary>
  [WordInteropEnumValue("wdFirstDataSourceRecord")]
  FirstDataSourceRecord = -6,
  /// <summary>
  /// The last record in the result set.
  /// </summary>
  [WordInteropEnumValue("wdLastRecord")]
  LastRecord = -5,
  /// <summary>
  /// The first record in the result set.
  /// </summary>
  [WordInteropEnumValue("wdFirstRecord")]
  FirstRecord = -4,
  /// <summary>
  /// The previous record in the result set.
  /// </summary>
  [WordInteropEnumValue("wdPreviousRecord")]
  PreviousRecord = -3,
  /// <summary>
  /// The next record in the result set.
  /// </summary>
  [WordInteropEnumValue("wdNextRecord")]
  NextRecord = -2,
  /// <summary>
  /// No active record.
  /// </summary>
  [WordInteropEnumValue("wdNoActiveRecord")]
  NoActiveRecord = -1
}
