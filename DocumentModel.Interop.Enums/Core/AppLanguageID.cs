namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a language setting in a Microsoft Office application.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoapplanguageid?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoAppLanguageID")]
public enum AppLanguageID
{
  /// <summary>
  /// Install language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDInstall")]
  Install = 1,
  /// <summary>
  /// User interface language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDUI")]
  UI,
  /// <summary>
  /// Help language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDHelp")]
  Help,
  /// <summary>
  /// Execution mode language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDExeMode")]
  ExeMode,
  /// <summary>
  /// User interface language used prior to the current user interface language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDUIPrevious")]
  UIPrevious
}
