namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the resolution and quality of the exported document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportoptimizefor?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdExportOptimizeFor")]
public enum ExportOptimizeFor
{
  /// <summary>
  /// Export for print, which is higher quailty and results in a larger file size.
  /// </summary>
  [WordInteropEnumValue("wdExportOptimizeForPrint")]
  Print = 0,
  /// <summary>
  /// Export for screen, which is a lower quality and results in a smaller file size.
  /// </summary>
  [WordInteropEnumValue("wdExportOptimizeForOnScreen")]
  OnScreen = 1
}
