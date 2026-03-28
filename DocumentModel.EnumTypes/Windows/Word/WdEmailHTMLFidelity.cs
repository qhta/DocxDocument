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
  /// Removes all HTML tags that do not affect how a message displays.
  /// </summary>
  Low = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  Medium = 2,
  /// <summary>
  /// Leaves HTML intact.
  /// </summary>
  High = 3
}
