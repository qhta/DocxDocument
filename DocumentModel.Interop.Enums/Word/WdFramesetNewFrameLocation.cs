namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a new frame in relation to an existing frame.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdframesetnewframelocation?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFramesetNewFrameLocation
{
  /// <summary>
  /// Above existing frame.
  /// </summary>
  Above = 0,
  /// <summary>
  /// Below existing frame.
  /// </summary>
  Below = 1,
  /// <summary>
  /// To the right of existing frame.
  /// </summary>
  Right = 2,
  /// <summary>
  /// To the left of existing frame.
  /// </summary>
  Left = 3
}
