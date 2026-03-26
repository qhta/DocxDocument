namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveoptions?view=office-pia` for Office interop details.
/// </remarks>
public enum SaveOptions
{
  /// <summary>
  /// Do not save pending changes.
  /// </summary>
  DoNotSaveChanges = 0,
  /// <summary>
  /// Prompt the user to save pending changes.
  /// </summary>
  PromptToSaveChanges = -2,
  /// <summary>
  /// Save pending changes automatically without prompting the user.
  /// </summary>
  SaveChanges = -1
}
