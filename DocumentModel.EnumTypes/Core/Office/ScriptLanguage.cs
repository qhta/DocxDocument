
namespace DocumentModel.HTML;

/// <summary>
/// Specifies scripting language of the active script.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlanguage?view=office-pia` for Office interop details.
/// </remarks>
public enum ScriptLanguage
{
  /// <summary>
  /// Java.
  /// </summary>
  Java = 1,
  /// <summary>
  /// Visual Basic.
  /// </summary>
  VisualBasic,
  /// <summary>
  /// Active Server Pages (ASP).
  /// </summary>
  ASP,
  /// <summary>
  /// A language other than ASP, Java, or Visual Basic.
  /// </summary>
  Other
}
