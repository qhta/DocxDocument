namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the styles and formatting to display in the Styles and Formatting task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshowfilter?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdShowFilter))]
public enum ShowFilter
{
  /// <summary>
  /// All styles available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShowFilter.wdShowFilterStylesAvailable))]
  StylesAvailable = 0,
  /// <summary>
  /// All styles in use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShowFilter.wdShowFilterStylesInUse))]
  StylesInUse = 1,
  /// <summary>
  /// All styles.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShowFilter.wdShowFilterStylesAll))]
  StylesAll = 2,
  /// <summary>
  /// All formatting in use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShowFilter.wdShowFilterFormattingInUse))]
  FormattingInUse = 3,
  /// <summary>
  /// All formatting available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShowFilter.wdShowFilterFormattingAvailable))]
  FormattingAvailable = 4,
  /// <summary>
  /// Only recommended styles.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdShowFilter.wdShowFilterFormattingRecommended))]
  FormattingRecommended = 5
}
