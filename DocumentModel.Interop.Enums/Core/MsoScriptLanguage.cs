
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies scripting language of the active script.
/// </summary>
public enum MsoScriptLanguage
{
  /// <summary>
  /// Java. msoScriptLanguageVisualBasic2 Visual Basic.
  /// </summary>
  msoScriptLanguageJava = 1,
  /// <summary>
  /// Specifies scripting language of the active script.
  /// </summary>
  msoScriptLanguageVisualBasic,
  /// <summary>
  /// Active Server Pages (ASP).
  /// </summary>
  msoScriptLanguageASP,
  /// <summary>
  /// A language other than ASP, Java, or Visual Basic.
  /// </summary>
  msoScriptLanguageOther
}
