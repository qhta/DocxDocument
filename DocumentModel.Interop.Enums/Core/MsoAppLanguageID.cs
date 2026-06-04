namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a language setting in a Microsoft Office application.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoapplanguageid?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoAppLanguageID))]
public enum AppLanguageID
{
  /// <summary>
  /// Install language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDInstall))]
  Install = 1,
  /// <summary>
  /// User interface language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))]
  UI,
  /// <summary>
  /// Help language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDHelp))]
  Help,
  /// <summary>
  /// Execution mode language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDExeMode))]
  ExeMode,
  /// <summary>
  /// User interface language used prior to the current user interface language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUIPrevious))]
  UIPrevious
}
