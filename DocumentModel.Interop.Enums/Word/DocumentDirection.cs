namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction to flow the text in a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumentdirection?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDocumentDirection")]
public enum DocumentDirection
{
  /// <summary>
  /// Left to right.
  /// </summary>
  [WordInteropEnumValue("wdLeftToRight")]
  LeftToRight = 0,
  /// <summary>
  /// Right to left.
  /// </summary>
  [WordInteropEnumValue("wdRightToLeft")]
  RightToLeft = 1
}
