namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of envelopes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenvelopeorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation))]
public enum EnvelopeOrientation
{
  /// <summary>
  /// Left portrait orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdLeftPortrait))]
  LeftPortrait = 0,
  /// <summary>
  /// Center portrait orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdCenterPortrait))]
  CenterPortrait = 1,
  /// <summary>
  /// Right portrait orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdRightPortrait))]
  RightPortrait = 2,
  /// <summary>
  /// Left landscape orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdLeftLandscape))]
  LeftLandscape = 3,
  /// <summary>
  /// Center landscape orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdCenterLandscape))]
  CenterLandscape = 4,
  /// <summary>
  /// Right landscape orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdRightLandscape))]
  RightLandscape = 5,
  /// <summary>
  /// Left clockwise orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdLeftClockwise))]
  LeftClockwise = 6,
  /// <summary>
  /// Center clockwise orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdCenterClockwise))]
  CenterClockwise = 7,
  /// <summary>
  /// Right clockwise orientation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnvelopeOrientation.wdRightClockwise))]
  RightClockwise = 8
}
