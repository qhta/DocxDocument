namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word measures the width of revision balloons.
/// </summary>
public enum WdRevisionsBalloonWidthType
{
  /// <summary>
  /// Measured as a percentage of the width of the document.
  /// </summary>
  wdBalloonWidthPercent = unchecked((int)0),
  /// <summary>
  /// Measured in points.
  /// </summary>
  wdBalloonWidthPoints = unchecked((int)1)
}
