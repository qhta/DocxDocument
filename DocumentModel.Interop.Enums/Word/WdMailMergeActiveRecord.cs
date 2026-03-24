namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active record in a mail merge result set.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergeactiverecord?view=office-pia` for Office interop details.
/// </remarks>
public enum WdMailMergeActiveRecord
{
  /// <summary>
  /// The previous record in the data source.
  /// </summary>
  PreviousDataSourceRecord = -9,
  /// <summary>
  /// The next record in the data source.
  /// </summary>
  NextDataSourceRecord = -8,
  /// <summary>
  /// The last record in the data source.
  /// </summary>
  LastDataSourceRecord = -7,
  /// <summary>
  /// The first record in the data source.
  /// </summary>
  FirstDataSourceRecord = -6,
  /// <summary>
  /// The last record in the result set.
  /// </summary>
  LastRecord = -5,
  /// <summary>
  /// The first record in the result set.
  /// </summary>
  FirstRecord = -4,
  /// <summary>
  /// The previous record in the result set.
  /// </summary>
  PreviousRecord = -3,
  /// <summary>
  /// The next record in the result set.
  /// </summary>
  NextRecord = -2,
  /// <summary>
  /// No active record.
  /// </summary>
  NoActiveRecord = -1
}
