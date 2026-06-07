namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the maximum length of an automatically generated document summary.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsummarylength?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSummaryLength")]
public enum SummaryLength
{
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd75Percent")]
  SummaryLength75Percent = -9,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd50Percent")]
  SummaryLength50Percent = -8,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd25Percent")]
  SummaryLength25Percent = -7,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd10Percent")]
  SummaryLength10Percent = -6,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd500Words")]
  SummaryLength500Words = -5,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd100Words")]
  SummaryLength100Words = -4,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd20Sentences")]
  SummaryLength20Sentences = -3,
  /// <summary>
  /// Specifies the maximum length of an automatically generated document summary.
  /// </summary>
  [InteropEnumValue("wd10Sentences")]
  SummaryLength10Sentences = -2
}
