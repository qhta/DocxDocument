namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to leave or remove HTML tags not required for display.
/// </summary>
public enum WdEmailHTMLFidelity
{
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  Low = unchecked((int)1),
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  Medium = unchecked((int)2),
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  High = unchecked((int)3)
}
