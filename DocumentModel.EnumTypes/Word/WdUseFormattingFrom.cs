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
  /// Copy source formatting from the current item.
  /// </summary>
  Current = 0,
  /// <summary>
  /// Copy source formatting from the current selection.
  /// </summary>
  Selected = 1,
  /// <summary>
  /// Prompt the user for formatting to use.
  /// </summary>
  Prompt = 2
}
