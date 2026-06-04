namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveoptions?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSaveOptions")]
public enum SaveOptions
{
  /// <summary>
  /// Do not save pending changes.
  /// </summary>
  [WordInteropEnumValue("wdDoNotSaveChanges")]
  DoNotSaveChanges = 0,
  /// <summary>
  /// Prompt the user to save pending changes.
  /// </summary>
  [WordInteropEnumValue("wdPromptToSaveChanges")]
  PromptToSaveChanges = -2,
  /// <summary>
  /// Save pending changes automatically without prompting the user.
  /// </summary>
  [WordInteropEnumValue("wdSaveChanges")]
  SaveChanges = -1
}
