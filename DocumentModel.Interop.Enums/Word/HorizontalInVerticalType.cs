namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of horizontal text set within vertical text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontalinverticaltype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdHorizontalInVerticalType))]
public enum HorizontalInVerticalType
{
  /// <summary>
  /// No formatting is applied to the horizontal text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalInVerticalType.wdHorizontalInVerticalNone))]
  None = 0,
  /// <summary>
  /// The horizontal text is sized to fit in the line of vertical text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalInVerticalType.wdHorizontalInVerticalFitInLine))]
  FitInLine = 1,
  /// <summary>
  /// The line of vertical text is sized to accommodate the horizontal text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalInVerticalType.wdHorizontalInVerticalResizeLine))]
  ResizeLine = 2
}
