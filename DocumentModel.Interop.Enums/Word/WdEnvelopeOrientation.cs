namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of envelopes.
/// </summary>
public enum WdEnvelopeOrientation
{
  /// <summary>
  /// Left portrait orientation.
  /// </summary>
  LeftPortrait = unchecked((int)0),
  /// <summary>
  /// Center portrait orientation.
  /// </summary>
  CenterPortrait = unchecked((int)1),
  /// <summary>
  /// Right portrait orientation.
  /// </summary>
  RightPortrait = unchecked((int)2),
  /// <summary>
  /// Left landscape orientation.
  /// </summary>
  LeftLandscape = unchecked((int)3),
  /// <summary>
  /// Center landscape orientation.
  /// </summary>
  CenterLandscape = unchecked((int)4),
  /// <summary>
  /// Right landscape orientation.
  /// </summary>
  RightLandscape = unchecked((int)5),
  /// <summary>
  /// Left clockwise orientation.
  /// </summary>
  LeftClockwise = unchecked((int)6),
  /// <summary>
  /// Center clockwise orientation.
  /// </summary>
  CenterClockwise = unchecked((int)7),
  /// <summary>
  /// Right clockwise orientation.
  /// </summary>
  RightClockwise = unchecked((int)8)
}
