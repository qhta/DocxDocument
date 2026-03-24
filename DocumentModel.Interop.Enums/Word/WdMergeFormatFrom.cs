namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document from which to retain formatting during a document compare function.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmergeformatfrom?view=office-pia` for Office interop details.
/// </remarks>
public enum WdMergeFormatFrom
{
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  Original = 0,
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  Revised = 1,
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  Prompt = 2
}
