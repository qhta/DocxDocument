namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the maximum length of an automatically generated document summary.
/// </summary>
public enum WdSummaryLength
{
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength75Percent = unchecked((int)-9),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength50Percent = unchecked((int)-8),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength25Percent = unchecked((int)-7),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength10Percent = unchecked((int)-6),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength500Words = unchecked((int)-5),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength100Words = unchecked((int)-4),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength20Sentences = unchecked((int)-3),
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength10Sentences = unchecked((int)-2)
}
