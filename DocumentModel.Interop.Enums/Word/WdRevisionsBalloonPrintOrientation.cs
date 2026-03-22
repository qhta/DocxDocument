namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of revision and comment balloons when they are printed.
/// </summary>
public enum WdRevisionsBalloonPrintOrientation
{
  /// <summary>
  /// Microsoft Word automatically selects the orientation that keeps the zoom factor closest to 100%.
  /// wdBalloonPrintOrientationPreserve1 Word preserves the orientation of the original, uncommented document.
  /// wdBalloonPrintOrientationForceLandscape2 Word forces all sections to be printed in Landscape mode, regardless
  /// of original orientation, and prints the revision and comment balloons on the side opposite to the document
  /// text.
  /// </summary>
  wdBalloonPrintOrientationAuto = unchecked((int)0),
  /// <summary>
  /// Specifies the orientation of revision and comment balloons when they are printed.
  /// </summary>
  wdBalloonPrintOrientationPreserve = unchecked((int)1),
  /// <summary>
  /// Specifies the orientation of revision and comment balloons when they are printed.
  /// </summary>
  wdBalloonPrintOrientationForceLandscape = unchecked((int)2)
}
