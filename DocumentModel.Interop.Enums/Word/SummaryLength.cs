namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the maximum length of an automatically generated document summary.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsummarylength?view=office-pia` for Office interop details.
/// </remarks>
public enum SummaryLength
{
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength75Percent = -9,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength50Percent = -8,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength25Percent = -7,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength10Percent = -6,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength500Words = -5,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength100Words = -4,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength20Sentences = -3,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  SummaryLength10Sentences = -2
}
