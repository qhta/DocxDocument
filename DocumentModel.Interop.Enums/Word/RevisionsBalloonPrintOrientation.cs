namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the orientation of revision and comment balloons when they are printed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsballoonprintorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRevisionsBalloonPrintOrientation))]
public enum RevisionsBalloonPrintOrientation
{
  /// <summary>
  /// Microsoft Word automatically selects the orientation that keeps the zoom factor closest to 100%.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsBalloonPrintOrientation.wdBalloonPrintOrientationAuto))]
  Auto = 0,
  /// <summary>
  /// Word preserves the orientation of the original, uncommented document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsBalloonPrintOrientation.wdBalloonPrintOrientationPreserve))]
  Preserve = 1,
  /// <summary>
  /// Word forces all sections to be printed in Landscape mode, regardless of original orientation, and prints the
  /// revision and comment balloons on the side opposite to the document text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsBalloonPrintOrientation.wdBalloonPrintOrientationForceLandscape))]
  ForceLandscape = 2
}
