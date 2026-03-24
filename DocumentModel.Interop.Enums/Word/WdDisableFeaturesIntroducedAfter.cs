namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the version of Microsoft Word for which to disable all features introduced after that version.
/// Applies only to the document for which the property is set when used with the DisableFeaturesIntroducedAfter
/// property or for all documents when used with the DisableFeaturesIntroducedAfterbyDefault property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddisablefeaturesintroducedafter?view=office-pia` for Office interop details.
/// </remarks>
public enum WdDisableFeaturesIntroducedAfter
{
  /// <summary>
  /// Specifies the version of Microsoft Word for which to disable all features introduced after that version.
  /// Applies only to the document for which the property is set when used with the DisableFeaturesIntroducedAfter
  /// property or for all documents when used with the DisableFeaturesIntroducedAfterbyDefault property.
  /// </summary>
  Word70 = 0,
  /// <summary>
  /// Specifies the version of Microsoft Word for which to disable all features introduced after that version.
  /// Applies only to the document for which the property is set when used with the DisableFeaturesIntroducedAfter
  /// property or for all documents when used with the DisableFeaturesIntroducedAfterbyDefault property.
  /// </summary>
  Word70FE = 1,
  /// <summary>
  /// Specifies the version of Microsoft Word for which to disable all features introduced after that version.
  /// Applies only to the document for which the property is set when used with the DisableFeaturesIntroducedAfter
  /// property or for all documents when used with the DisableFeaturesIntroducedAfterbyDefault property.
  /// </summary>
  Word80 = 2
}
