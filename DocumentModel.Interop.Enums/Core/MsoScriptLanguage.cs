
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies scripting language of the active script.
/// </summary>
public enum MsoScriptLanguage
{
  /// <summary>
  /// Java. msoScriptLanguageVisualBasic2 Visual Basic.
  /// </summary>
  Java = 1,
  /// <summary>
  /// Specifies scripting language of the active script.
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
