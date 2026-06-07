namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the version of Microsoft Word for which to disable all features introduced after that version.
/// Applies only to the document for which the property is set when used with the DisableFeaturesIntroducedAfter
/// property or for all documents when used with the DisableFeaturesIntroducedAfterbyDefault property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddisablefeaturesintroducedafter?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDisableFeaturesIntroducedAfter")]
public enum DisableFeaturesIntroducedAfter
{
  /// <summary>
  /// Specifies Word for Windows 95, versions 7.0 and 7.0a.
  /// </summary>
  [InteropEnumValue("wd70")]
  Wd70 = 0,
  /// <summary>
  /// Specifies Word for Windows 95, versions 7.0 and 7.0a, Asian edition.
  /// </summary>
  [InteropEnumValue("wd70FE")]
  Wd70FE = 1,
  /// <summary>
  /// Specifies Word 97 for Windows. Default.
  /// </summary>
  [InteropEnumValue("wd80")]
  Wd80 = 2
}
