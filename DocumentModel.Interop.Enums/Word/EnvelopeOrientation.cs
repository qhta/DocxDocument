namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of envelopes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenvelopeorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdEnvelopeOrientation")]
public enum EnvelopeOrientation
{
  /// <summary>
  /// Left portrait orientation.
  /// </summary>
  [WordInteropEnumValue("wdLeftPortrait")]
  LeftPortrait = 0,
  /// <summary>
  /// Center portrait orientation.
  /// </summary>
  [WordInteropEnumValue("wdCenterPortrait")]
  CenterPortrait = 1,
  /// <summary>
  /// Right portrait orientation.
  /// </summary>
  [WordInteropEnumValue("wdRightPortrait")]
  RightPortrait = 2,
  /// <summary>
  /// Left landscape orientation.
  /// </summary>
  [WordInteropEnumValue("wdLeftLandscape")]
  LeftLandscape = 3,
  /// <summary>
  /// Center landscape orientation.
  /// </summary>
  [WordInteropEnumValue("wdCenterLandscape")]
  CenterLandscape = 4,
  /// <summary>
  /// Right landscape orientation.
  /// </summary>
  [WordInteropEnumValue("wdRightLandscape")]
  RightLandscape = 5,
  /// <summary>
  /// Left clockwise orientation.
  /// </summary>
  [WordInteropEnumValue("wdLeftClockwise")]
  LeftClockwise = 6,
  /// <summary>
  /// Center clockwise orientation.
  /// </summary>
  [WordInteropEnumValue("wdCenterClockwise")]
  CenterClockwise = 7,
  /// <summary>
  /// Right clockwise orientation.
  /// </summary>
  [WordInteropEnumValue("wdRightClockwise")]
  RightClockwise = 8
}
