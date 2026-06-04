namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to interpret the height or width of a specified frame on a frames page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesetsizetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFramesetSizeType))]
public enum FramesetSizeType
{
  /// <summary>
  /// Word interprets the height or width of the specified frame as a percentage of the screen height or width.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetSizeType.wdFramesetSizeTypePercent))]
  Percent = 0,
  /// <summary>
  /// Microsoft Word interprets the height or width of the specified frame as a fixed value (in points).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetSizeType.wdFramesetSizeTypeFixed))]
  Fixed = 1,
  /// <summary>
  /// Word interprets the height or width of the specified frame as relative to the height or width of other frames
  /// on the frames page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetSizeType.wdFramesetSizeTypeRelative))]
  Relative = 2
}
