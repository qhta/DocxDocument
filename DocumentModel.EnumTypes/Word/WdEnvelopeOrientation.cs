namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of envelopes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenvelopeorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum EnvelopeOrientation
{
  /// <summary>
  /// Left portrait orientation.
  /// </summary>
  LeftPortrait = 0,
  /// <summary>
  /// Center portrait orientation.
  /// </summary>
  CenterPortrait = 1,
  /// <summary>
  /// Right portrait orientation.
  /// </summary>
  RightPortrait = 2,
  /// <summary>
  /// Left landscape orientation.
  /// </summary>
  LeftLandscape = 3,
  /// <summary>
  /// Center landscape orientation.
  /// </summary>
  CenterLandscape = 4,
  /// <summary>
  /// Right landscape orientation.
  /// </summary>
  RightLandscape = 5,
  /// <summary>
  /// Left clockwise orientation.
  /// </summary>
  LeftClockwise = 6,
  /// <summary>
  /// Center clockwise orientation.
  /// </summary>
  CenterClockwise = 7,
  /// <summary>
  /// Right clockwise orientation.
  /// </summary>
  RightClockwise = 8
}
