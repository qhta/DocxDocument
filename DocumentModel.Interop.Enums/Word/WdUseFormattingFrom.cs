namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a source to copy formatting from.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wduseformattingfrom?view=office-pia` for Office interop details.
/// </remarks>
public enum WdUseFormattingFrom
{
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  Current = 0,
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  Selected = 1,
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  Prompt = 2
}
