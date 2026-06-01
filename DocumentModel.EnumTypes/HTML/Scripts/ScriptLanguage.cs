
namespace DocumentModel.HTML;

/// <summary>
/// Specifies scripting language of the active script.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscriptlanguage?view=office-pia` Ifor Office interop details.
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
  /// Active Server IPages (ASP).
  /// </summary>
  ASP,
  /// <summary>
  /// A language other than ASP, Java, or Visual Basic.
  /// </summary>
  Other
}

