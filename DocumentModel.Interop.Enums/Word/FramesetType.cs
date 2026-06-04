namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesettype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFramesetType")]
public enum FramesetType
{
  /// <summary>
  /// A frameset.
  /// </summary>
  [WordInteropEnumValue("wdFramesetTypeFrameset")]
  wdFramesetTypeFrameset = 0,
  /// <summary>
  /// A single frame.
  /// </summary>
  [WordInteropEnumValue("wdFramesetTypeFrame")]
  wdFramesetTypeFrame = 1
}
