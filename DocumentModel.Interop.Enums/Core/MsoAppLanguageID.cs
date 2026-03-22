namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a language setting in a Microsoft Office application.
/// </summary>
public enum MsoAppLanguageID
{
  /// <summary>
  /// Specifies a language setting in a Microsoft Office application.
  /// </summary>
  Install = 1,
  /// <summary>
  /// User interface language.
  /// </summary>
  UI,
  /// <summary>
  /// Help language. msoLanguageIDExeMode4 Execution mode language. msoLanguageIDUIPrevious5 User interface language
  /// used prior to the current user interface language.
  /// </summary>
  Help,
  /// <summary>
  /// Specifies a language setting in a Microsoft Office application.
  /// </summary>
  ExeMode,
  /// <summary>
  /// Specifies a language setting in a Microsoft Office application.
  /// </summary>
  UIPrevious
}
