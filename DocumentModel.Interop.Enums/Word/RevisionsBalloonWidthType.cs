namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word measures the width of revision balloons.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsballoonwidthtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRevisionsBalloonWidthType))]
public enum RevisionsBalloonWidthType
{
  /// <summary>
  /// Measured as a percentage of the width of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsBalloonWidthType.wdBalloonWidthPercent))]
  Percent = 0,
  /// <summary>
  /// Measured in points.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionsBalloonWidthType.wdBalloonWidthPoints))]
  Points = 1
}
