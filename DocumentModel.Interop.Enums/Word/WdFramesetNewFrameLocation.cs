namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a new frame in relation to an existing frame.
/// </summary>
public enum WdFramesetNewFrameLocation
{
  /// <summary>
  /// Above existing frame.
  /// </summary>
  Above = unchecked((int)0),
  /// <summary>
  /// Below existing frame.
  /// </summary>
  Below = unchecked((int)1),
  /// <summary>
  /// To the right of existing frame.
  /// </summary>
  Right = unchecked((int)2),
  /// <summary>
  /// To the left of existing frame.
  /// </summary>
  Left = unchecked((int)3)
}
