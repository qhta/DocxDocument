namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesettype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFramesetType")]
public enum FramesetType
{
  /// <summary>
  /// A frameset.
  /// </summary>
  [InteropEnumValue("wdFramesetTypeFrameset")]
  wdFramesetTypeFrameset = 0,
  /// <summary>
  /// A single frame.
  /// </summary>
  [InteropEnumValue("wdFramesetTypeFrame")]
  wdFramesetTypeFrame = 1
}
