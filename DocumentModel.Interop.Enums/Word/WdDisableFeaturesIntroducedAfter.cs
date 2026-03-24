namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the version of Microsoft Word for which to disable all features introduced after that version.
/// Applies only to the document for which the property is set when used with the DisableFeaturesIntroducedAfter
/// property or for all documents when used with the DisableFeaturesIntroducedAfterbyDefault property.
/// </summary>
public enum WdDisableFeaturesIntroducedAfter
{
  /// <summary>
  /// Specifies Word for Windows 95, versions 7.0 and 7.0a.
  /// </summary>
  Word70 = unchecked((int)0),
  /// <summary>
  /// Specifies Word for Windows 95, versions 7.0 and 7.0a, Asian edition.
  /// </summary>
  Word70FE = unchecked((int)1),
  /// <summary>
  /// Specifies Word for Windows 98, versions 8.0.
  /// </summary>
  Word80 = unchecked((int)2)
}
