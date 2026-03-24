namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the styles and formatting to display in the Styles and Formatting task pane.
/// </summary>
public enum WdShowFilter
{
  /// <summary>
  /// All styles available.
  /// </summary>
  StylesAvailable = unchecked((int)0),
  /// <summary>
  /// All styles in use.
  /// </summary>
  StylesInUse = unchecked((int)1),
  /// <summary>
  /// All styles.
  /// </summary>
  StylesAll = unchecked((int)2),
  /// <summary>
  /// All formatting in use.
  /// </summary>
  FormattingInUse = unchecked((int)3),
  /// <summary>
  /// All formatting available.
  /// </summary>
  FormattingAvailable = unchecked((int)4),
  /// <summary>
  /// Only recommended styles.
  /// </summary>
  FormattingRecommended = unchecked((int)5)
}
