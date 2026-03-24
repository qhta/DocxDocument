namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to interpret the height or width of a specified frame on a frames page.
/// </summary>
public enum WdFramesetSizeType
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
