namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the caption label text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCaptionPosition))]
public enum CaptionPosition
{
  /// <summary>
  /// The caption label is added above.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionPosition.wdCaptionPositionAbove))]
  Above = 0,
  /// <summary>
  /// The caption label is added below.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionPosition.wdCaptionPositionBelow))]
  Below = 1
}
