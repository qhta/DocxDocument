namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reference point against which the frame position is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframeposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFramePosition")]
public enum FramePosition
{
  /// <summary>
  /// Top margin.
  /// </summary>
  [WordInteropEnumValue("wdFrameTop")]
  Top = -999999,
  /// <summary>
  /// Left margin.
  /// </summary>
  [WordInteropEnumValue("wdFrameLeft")]
  Left = -999998,
  /// <summary>
  /// Bottom margin.
  /// </summary>
  [WordInteropEnumValue("wdFrameBottom")]
  Bottom = -999997,
  /// <summary>
  /// Right margin.
  /// </summary>
  [WordInteropEnumValue("wdFrameRight")]
  Right = -999996,
  /// <summary>
  /// Center of document.
  /// </summary>
  [WordInteropEnumValue("wdFrameCenter")]
  Center = -999995,
  /// <summary>
  /// Content on inside of frame.
  /// </summary>
  [WordInteropEnumValue("wdFrameInside")]
  Inside = -999994,
  /// <summary>
  /// Content on outside of frame.
  /// </summary>
  [WordInteropEnumValue("wdFrameOutside")]
  Outside = -999993
}
