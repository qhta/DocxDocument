namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the maximum length of an automatically generated document summary.
/// </summary>
public enum WdSummaryLength
{
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd75Percent = unchecked((int)-9),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd50Percent = unchecked((int)-8),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd25Percent = unchecked((int)-7),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd10Percent = unchecked((int)-6),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd500Words = unchecked((int)-5),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd100Words = unchecked((int)-4),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd20Sentences = unchecked((int)-3),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  wd10Sentences = unchecked((int)-2)
}
