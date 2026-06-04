namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdparagraphalignmenthid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdParagraphAlignmentHID))]
public enum ParagraphAlignmentHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdParagraphAlignmentHID.emptyenum))]
  emptyenum = 0
}
