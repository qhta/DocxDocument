namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the styles and formatting to display in the Styles and Formatting task pane.
/// </summary>
public enum WdShowFilter
{
  /// <summary>
  /// All styles available.
  /// </summary>
  StylesAvailable = 0,
  /// <summary>
  /// All styles in use.
  /// </summary>
  StylesInUse = 1,
  /// <summary>
  /// All styles.
  /// </summary>
  StylesAll = 2,
  /// <summary>
  /// All formatting in use.
  /// </summary>
  FormattingInUse = 3,
  /// <summary>
  /// All formatting available.
  /// </summary>
  FormattingAvailable = 4,
  /// <summary>
  /// Only recommended styles.
  /// </summary>
  FormattingRecommended = 5
}
