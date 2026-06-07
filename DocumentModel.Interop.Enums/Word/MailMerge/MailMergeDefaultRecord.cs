namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default record to use in a mail merge process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergedefaultrecord?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMailMergeDefaultRecord")]
public enum MailMergeDefaultRecord
{
  /// <summary>
  /// Use the first record in the result set as the default record.
  /// </summary>
  [InteropEnumValue("wdDefaultFirstRecord")]
  FirstRecord = 1,
  /// <summary>
  /// Use the last record in the result set as the default record.
  /// </summary>
  [InteropEnumValue("wdDefaultLastRecord")]
  LastRecord = -16
}
