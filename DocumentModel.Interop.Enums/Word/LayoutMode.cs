namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how text is laid out in the layout mode for the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdlayoutmode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLayoutMode))]
public enum LayoutMode
{
  /// <summary>
  /// No grid is used to lay out text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLayoutMode.wdLayoutModeDefault))]
  Default = 0,
  /// <summary>
  /// Text is laid out on a grid; the user specifies the number of lines and the number of characters per line. As
  /// the user types, Microsoft Word doesn't automatically align characters with gridlines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLayoutMode.wdLayoutModeGrid))]
  Grid = 1,
  /// <summary>
  /// Text is laid out on a grid; the user specifies the number of lines, but not the number of characters per line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLayoutMode.wdLayoutModeLineGrid))]
  LineGrid = 2,
  /// <summary>
  /// Text is laid out on a grid; the user specifies the number of lines and the number of characters per line. As
  /// the user types, Microsoft Word automatically aligns characters with gridlines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLayoutMode.wdLayoutModeGenko))]
  Genko = 3
}
