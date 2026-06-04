namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type for a caption label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionlabelid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCaptionLabelID))]
public enum CaptionLabelID
{
  /// <summary>
  /// Equation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionLabelID.wdCaptionEquation))]
  Equation = -3,
  /// <summary>
  /// Table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionLabelID.wdCaptionTable))]
  Table = -2,
  /// <summary>
  /// Figure.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCaptionLabelID.wdCaptionFigure))]
  Figure = -1
}
