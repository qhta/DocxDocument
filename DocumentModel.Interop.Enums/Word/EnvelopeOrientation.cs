namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of envelopes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenvelopeorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdEnvelopeOrientation")]
public enum EnvelopeOrientation
{
  /// <summary>
  /// Left portrait orientation.
  /// </summary>
  [InteropEnumValue("wdLeftPortrait")]
  LeftPortrait = 0,
  /// <summary>
  /// Center portrait orientation.
  /// </summary>
  [InteropEnumValue("wdCenterPortrait")]
  CenterPortrait = 1,
  /// <summary>
  /// Right portrait orientation.
  /// </summary>
  [InteropEnumValue("wdRightPortrait")]
  RightPortrait = 2,
  /// <summary>
  /// Left landscape orientation.
  /// </summary>
  [InteropEnumValue("wdLeftLandscape")]
  LeftLandscape = 3,
  /// <summary>
  /// Center landscape orientation.
  /// </summary>
  [InteropEnumValue("wdCenterLandscape")]
  CenterLandscape = 4,
  /// <summary>
  /// Right landscape orientation.
  /// </summary>
  [InteropEnumValue("wdRightLandscape")]
  RightLandscape = 5,
  /// <summary>
  /// Left clockwise orientation.
  /// </summary>
  [InteropEnumValue("wdLeftClockwise")]
  LeftClockwise = 6,
  /// <summary>
  /// Center clockwise orientation.
  /// </summary>
  [InteropEnumValue("wdCenterClockwise")]
  CenterClockwise = 7,
  /// <summary>
  /// Right clockwise orientation.
  /// </summary>
  [InteropEnumValue("wdRightClockwise")]
  RightClockwise = 8
}
