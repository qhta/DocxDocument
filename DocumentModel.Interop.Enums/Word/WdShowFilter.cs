namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the styles and formatting to display in the Styles and Formatting task pane.
/// </summary>
public enum WdShowFilter
{
  /// <summary>
  /// All styles available.
  /// </summary>
  wdShowFilterStylesAvailable = unchecked((int)0),
  /// <summary>
  /// All styles in use.
  /// </summary>
  wdShowFilterStylesInUse = unchecked((int)1),
  /// <summary>
  /// All styles.
  /// </summary>
  wdShowFilterStylesAll = unchecked((int)2),
  /// <summary>
  /// All formatting in use.
  /// </summary>
  wdShowFilterFormattingInUse = unchecked((int)3),
  /// <summary>
  /// All formatting available.
  /// </summary>
  wdShowFilterFormattingAvailable = unchecked((int)4),
  /// <summary>
  /// Only recommended styles.
  /// </summary>
  wdShowFilterFormattingRecommended = unchecked((int)5)
}
