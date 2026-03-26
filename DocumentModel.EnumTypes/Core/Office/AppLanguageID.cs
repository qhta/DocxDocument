namespace DocumentMode.Office;

/// <summary>
/// Specifies a language setting in a Microsoft Office application.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoapplanguageid?view=office-pia` for Office interop details.
/// </remarks>
public enum AppLanguageID
{
  /// <summary>
  /// Install language.
  /// </summary>
  Install = 1,
  /// <summary>
  /// User interface language.
  /// </summary>
  UI,
  /// <summary>
  /// Help language.
  /// </summary>
  Help,
  /// <summary>
  /// Execution mode language.
  /// </summary>
  ExeMode,
  /// <summary>
  /// User interface language used prior to the current user interface language.
  /// </summary>
  UIPrevious
}
