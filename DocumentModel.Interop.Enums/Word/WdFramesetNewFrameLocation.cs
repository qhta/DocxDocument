namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a new frame in relation to an existing frame.
/// </summary>
public enum WdFramesetNewFrameLocation
{
  /// <summary>
  /// Above existing frame.
  /// </summary>
  wdFramesetNewFrameAbove = unchecked((int)0),
  /// <summary>
  /// Below existing frame.
  /// </summary>
  wdFramesetNewFrameBelow = unchecked((int)1),
  /// <summary>
  /// To the right of existing frame.
  /// </summary>
  wdFramesetNewFrameRight = unchecked((int)2),
  /// <summary>
  /// To the left of existing frame.
  /// </summary>
  wdFramesetNewFrameLeft = unchecked((int)3)
}
