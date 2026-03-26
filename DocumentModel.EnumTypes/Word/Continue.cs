namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the formatting from the previous list can be continued.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontinue?view=office-pia` for Office interop details.
/// </remarks>
public enum Continue
{
  /// <summary>
  /// Formatting cannot continue from the previous list.
  /// </summary>
  ContinueDisabled = 0,
  /// <summary>
  /// Numbering can be restarted.
  /// </summary>
  ResetList = 1,
  /// <summary>
  /// Formatting can continue from the previous list.
  /// </summary>
  ContinueList = 2
}
