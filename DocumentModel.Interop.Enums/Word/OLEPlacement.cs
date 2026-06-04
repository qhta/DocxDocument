namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement for an OLE object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoleplacement?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOLEPlacement))]
public enum OLEPlacement
{
  /// <summary>
  /// In line with text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOLEPlacement.wdInLine))]
  InLine = 0,
  /// <summary>
  /// Float over text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOLEPlacement.wdFloatOverText))]
  FloatOverText = 1
}
