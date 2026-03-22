namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a language setting in a Microsoft Office application.
/// </summary>
public enum MsoAppLanguageID
{
  /// <summary>
  /// Specifies a language setting in a Microsoft Office application.
  /// </summary>
  msoLanguageIDInstall = 1,
  /// <summary>
  /// User interface language.
  /// </summary>
  msoLanguageIDUI,
  /// <summary>
  /// Help language. msoLanguageIDExeMode4 Execution mode language. msoLanguageIDUIPrevious5 User interface language
  /// used prior to the current user interface language.
  /// </summary>
  msoLanguageIDHelp,
  /// <summary>
  /// Specifies a language setting in a Microsoft Office application.
  /// </summary>
  msoLanguageIDExeMode,
  /// <summary>
  /// Specifies a language setting in a Microsoft Office application.
  /// </summary>
  msoLanguageIDUIPrevious
}
