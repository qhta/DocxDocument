
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies scripting language of the active script.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlanguage?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoScriptLanguage))]
public enum ScriptLanguage
{
  /// <summary>
  /// Java.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScriptLanguage.msoScriptLanguageJava))]
  Java = 1,
  /// <summary>
  /// Visual Basic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScriptLanguage.msoScriptLanguageVisualBasic))]
  VisualBasic,
  /// <summary>
  /// Active Server Pages (ASP).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScriptLanguage.msoScriptLanguageASP))]
  ASP,
  /// <summary>
  /// A language other than ASP, Java, or Visual Basic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoScriptLanguage.msoScriptLanguageOther))]
  Other
}
