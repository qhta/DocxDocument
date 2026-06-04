namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reference point against which the frame position is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframeposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFramePosition))]
public enum FramePosition
{
  /// <summary>
  /// Top margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameTop))]
  Top = -999999,
  /// <summary>
  /// Left margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameLeft))]
  Left = -999998,
  /// <summary>
  /// Bottom margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameBottom))]
  Bottom = -999997,
  /// <summary>
  /// Right margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameRight))]
  Right = -999996,
  /// <summary>
  /// Center of document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameCenter))]
  Center = -999995,
  /// <summary>
  /// Content on inside of frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameInside))]
  Inside = -999994,
  /// <summary>
  /// Content on outside of frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramePosition.wdFrameOutside))]
  Outside = -999993
}
