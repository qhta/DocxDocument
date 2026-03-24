namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reference point against which the frame position is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframeposition?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFramePosition
{
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Top = -999999,
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Left = -999998,
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Bottom = -999997,
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Right = -999996,
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Center = -999995,
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Inside = -999994,
  /// <summary>
  /// Specifies the reference point against which the frame position is calculated.
  /// </summary>
  Outside = -999993
}
