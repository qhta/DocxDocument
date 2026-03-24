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
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  PreviousDataSourceRecord = -9,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  NextDataSourceRecord = -8,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  LastDataSourceRecord = -7,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  FirstDataSourceRecord = -6,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  LastRecord = -5,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  FirstRecord = -4,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  PreviousRecord = -3,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  NextRecord = -2,
  /// <summary>
  /// Specifies the active record in a mail merge result set.
  /// </summary>
  NoActiveRecord = -1
}
