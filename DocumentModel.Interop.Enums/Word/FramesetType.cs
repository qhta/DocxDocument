namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesettype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFramesetType))]
public enum FramesetType
{
  /// <summary>
  /// A frameset.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetType.wdFramesetTypeFrameset))]
  wdFramesetTypeFrameset = 0,
  /// <summary>
  /// A single frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetType.wdFramesetTypeFrame))]
  wdFramesetTypeFrame = 1
}
