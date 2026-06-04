
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies scripting language of the active script.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlanguage?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoScriptLanguage")]
public enum ScriptLanguage
{
  /// <summary>
  /// Java.
  /// </summary>
  [InteropEnumValue("msoScriptLanguageJava")]
  Java = 1,
  /// <summary>
  /// Visual Basic.
  /// </summary>
  [InteropEnumValue("msoScriptLanguageVisualBasic")]
  VisualBasic,
  /// <summary>
  /// Active Server Pages (ASP).
  /// </summary>
  [InteropEnumValue("msoScriptLanguageASP")]
  ASP,
  /// <summary>
  /// A language other than ASP, Java, or Visual Basic.
  /// </summary>
  [InteropEnumValue("msoScriptLanguageOther")]
  Other
}
