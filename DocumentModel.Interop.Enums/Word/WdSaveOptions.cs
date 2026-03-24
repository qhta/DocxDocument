namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how pending changes should be handled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveoptions?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSaveOptions
{
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  DoNotSaveChanges = 0,
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  PromptToSaveChanges = -2,
  /// <summary>
  /// Specifies how pending changes should be handled.
  /// </summary>
  SaveChanges = -1
}
