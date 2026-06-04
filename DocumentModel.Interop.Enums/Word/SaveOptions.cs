namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveoptions?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSaveOptions))]
public enum SaveOptions
{
  /// <summary>
  /// Do not save pending changes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges))]
  DoNotSaveChanges = 0,
  /// <summary>
  /// Prompt the user to save pending changes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveOptions.wdPromptToSaveChanges))]
  PromptToSaveChanges = -2,
  /// <summary>
  /// Save pending changes automatically without prompting the user.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSaveOptions.wdSaveChanges))]
  SaveChanges = -1
}
