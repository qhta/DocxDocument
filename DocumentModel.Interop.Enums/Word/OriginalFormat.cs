namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document format. This enumeration is commonly used when saving a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoriginalformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOriginalFormat")]
public enum OriginalFormat
{
  /// <summary>
  /// Microsoft Word document format.
  /// </summary>
  [WordInteropEnumValue("wdWordDocument")]
  WordDocument = 0,
  /// <summary>
  /// Original document format.
  /// </summary>
  [WordInteropEnumValue("wdOriginalDocumentFormat")]
  OriginalDocumentFormat = 1,
  /// <summary>
  /// Prompt user to select a document format.
  /// </summary>
  [WordInteropEnumValue("wdPromptUser")]
  PromptUser = 2
}
