namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to leave or remove HTML tags not required for display.
/// </summary>
public enum WdEmailHTMLFidelity
{
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  wdEmailHTMLFidelityLow = unchecked((int)1),
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  wdEmailHTMLFidelityMedium = unchecked((int)2),
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  wdEmailHTMLFidelityHigh = unchecked((int)3)
}
