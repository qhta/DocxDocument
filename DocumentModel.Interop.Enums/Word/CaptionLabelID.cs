namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type for a caption label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionlabelid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdCaptionLabelID")]
public enum CaptionLabelID
{
  /// <summary>
  /// Equation.
  /// </summary>
  [WordInteropEnumValue("wdCaptionEquation")]
  Equation = -3,
  /// <summary>
  /// Table.
  /// </summary>
  [WordInteropEnumValue("wdCaptionTable")]
  Table = -2,
  /// <summary>
  /// Figure.
  /// </summary>
  [WordInteropEnumValue("wdCaptionFigure")]
  Figure = -1
}
