namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default record to use in a mail merge process.
/// </summary>
public enum WdMailMergeDefaultRecord
{
  /// <summary>
  /// Use the first record in the result set as the default record.
  /// </summary>
  FirstRecord = unchecked((int)1),
  /// <summary>
  /// Specifies the default record to use in a mail merge process.
  /// </summary>
  LastRecord = unchecked((int)-16)
}
