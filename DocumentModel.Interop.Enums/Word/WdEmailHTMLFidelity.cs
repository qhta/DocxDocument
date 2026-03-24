namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to leave or remove HTML tags not required for display.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdemailhtmlfidelity?view=office-pia` for Office interop details.
/// </remarks>
public enum WdEmailHTMLFidelity
{
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  Low = 1,
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  Medium = 2,
  /// <summary>
  /// Specifies whether to leave or remove HTML tags not required for display.
  /// </summary>
  High = 3
}
