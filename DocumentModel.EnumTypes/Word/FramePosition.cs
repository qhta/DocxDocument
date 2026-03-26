namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the reference point against which the frame position is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframeposition?view=office-pia` for Office interop details.
/// </remarks>
public enum FramePosition
{
  /// <summary>
  /// Top margin.
  /// </summary>
  Top = -999999,
  /// <summary>
  /// Left margin.
  /// </summary>
  Left = -999998,
  /// <summary>
  /// Bottom margin.
  /// </summary>
  Bottom = -999997,
  /// <summary>
  /// Right margin.
  /// </summary>
  Right = -999996,
  /// <summary>
  /// Center of document.
  /// </summary>
  Center = -999995,
  /// <summary>
  /// Content on inside of frame.
  /// </summary>
  Inside = -999994,
  /// <summary>
  /// Content on outside of frame.
  /// </summary>
  Outside = -999993
}
