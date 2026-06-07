namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type for a caption label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionlabelid?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCaptionLabelID")]
public enum CaptionLabelID
{
  /// <summary>
  /// Equation.
  /// </summary>
  [InteropEnumValue("wdCaptionEquation")]
  Equation = -3,
  /// <summary>
  /// Table.
  /// </summary>
  [InteropEnumValue("wdCaptionTable")]
  Table = -2,
  /// <summary>
  /// Figure.
  /// </summary>
  [InteropEnumValue("wdCaptionFigure")]
  Figure = -1
}
