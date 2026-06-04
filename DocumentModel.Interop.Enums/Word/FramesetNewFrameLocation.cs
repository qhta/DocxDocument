namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a new frame in relation to an existing frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesetnewframelocation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFramesetNewFrameLocation))]
public enum FramesetNewFrameLocation
{
  /// <summary>
  /// Above existing frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetNewFrameLocation.wdFramesetNewFrameAbove))]
  Above = 0,
  /// <summary>
  /// Below existing frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetNewFrameLocation.wdFramesetNewFrameBelow))]
  Below = 1,
  /// <summary>
  /// To the right of existing frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetNewFrameLocation.wdFramesetNewFrameRight))]
  Right = 2,
  /// <summary>
  /// To the left of existing frame.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFramesetNewFrameLocation.wdFramesetNewFrameLeft))]
  Left = 3
}
