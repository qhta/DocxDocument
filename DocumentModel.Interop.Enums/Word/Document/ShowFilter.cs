namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the styles and formatting to display in the Styles and Formatting task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshowfilter?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdShowFilter")]
public enum ShowFilter
{
  /// <summary>
  /// All styles available.
  /// </summary>
  [InteropEnumValue("wdShowFilterStylesAvailable")]
  StylesAvailable = 0,
  /// <summary>
  /// All styles in use.
  /// </summary>
  [InteropEnumValue("wdShowFilterStylesInUse")]
  StylesInUse = 1,
  /// <summary>
  /// All styles.
  /// </summary>
  [InteropEnumValue("wdShowFilterStylesAll")]
  StylesAll = 2,
  /// <summary>
  /// All formatting in use.
  /// </summary>
  [InteropEnumValue("wdShowFilterFormattingInUse")]
  FormattingInUse = 3,
  /// <summary>
  /// All formatting available.
  /// </summary>
  [InteropEnumValue("wdShowFilterFormattingAvailable")]
  FormattingAvailable = 4,
  /// <summary>
  /// Only recommended styles.
  /// </summary>
  [InteropEnumValue("wdShowFilterFormattingRecommended")]
  FormattingRecommended = 5
}
