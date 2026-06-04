namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a language setting in a Microsoft Office application.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoapplanguageid?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoAppLanguageID")]
public enum AppLanguageID
{
  /// <summary>
  /// Install language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDInstall")]
  Install = 1,
  /// <summary>
  /// User interface language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDUI")]
  UI,
  /// <summary>
  /// Help language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDHelp")]
  Help,
  /// <summary>
  /// Execution mode language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDExeMode")]
  ExeMode,
  /// <summary>
  /// User interface language used prior to the current user interface language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDUIPrevious")]
  UIPrevious
}
