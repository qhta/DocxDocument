namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of envelopes.
/// </summary>
public enum WdEnvelopeOrientation
{
  /// <summary>
  /// Left portrait orientation.
  /// </summary>
  wdLeftPortrait = unchecked((int)0),
  /// <summary>
  /// Center portrait orientation.
  /// </summary>
  wdCenterPortrait = unchecked((int)1),
  /// <summary>
  /// Right portrait orientation.
  /// </summary>
  wdRightPortrait = unchecked((int)2),
  /// <summary>
  /// Left landscape orientation.
  /// </summary>
  wdLeftLandscape = unchecked((int)3),
  /// <summary>
  /// Center landscape orientation.
  /// </summary>
  wdCenterLandscape = unchecked((int)4),
  /// <summary>
  /// Right landscape orientation.
  /// </summary>
  wdRightLandscape = unchecked((int)5),
  /// <summary>
  /// Left clockwise orientation.
  /// </summary>
  wdLeftClockwise = unchecked((int)6),
  /// <summary>
  /// Center clockwise orientation.
  /// </summary>
  wdCenterClockwise = unchecked((int)7),
  /// <summary>
  /// Right clockwise orientation.
  /// </summary>
  wdRightClockwise = unchecked((int)8)
}
