namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies how to interpret the height or width of a specified frame on a frames page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesetsizetype?view=office-pia` for Office interop details.
/// </remarks>
public enum FramesetSizeType
{
  /// <summary>
  /// Word interprets the height or width of the specified frame as a percentage of the screen height or width.
  /// </summary>
  Percent = 0,
  /// <summary>
  /// Microsoft Word interprets the height or width of the specified frame as a fixed value (in points).
  /// </summary>
  Fixed = 1,
  /// <summary>
  /// Word interprets the height or width of the specified frame as relative to the height or width of other frames
  /// on the frames page.
  /// </summary>
  Relative = 2
}
