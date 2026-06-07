namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document from which to retain formatting during a document compare function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmergeformatfrom?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMergeFormatFrom")]
public enum MergeFormatFrom
{
  /// <summary>
  /// Retains formatting from the original document.
  /// </summary>
  [InteropEnumValue("wdMergeFormatFromOriginal")]
  Original = 0,
  /// <summary>
  /// Retains formatting from the revised document.
  /// </summary>
  [InteropEnumValue("wdMergeFormatFromRevised")]
  Revised = 1,
  /// <summary>
  /// Prompt the user for the document to use for formatting.
  /// </summary>
  [InteropEnumValue("wdMergeFormatFromPrompt")]
  Prompt = 2
}
