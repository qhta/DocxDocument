namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the resolution and quality of the exported document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportoptimizefor?view=office-pia` for Office interop details.
/// </remarks>
public enum WdExportOptimizeFor
{
  /// <summary>
  /// Export for print, which is higher quailty and results in a larger file size.
  /// </summary>
  Print = 0,
  /// <summary>
  /// Export for screen, which is a lower quality and results in a smaller file size.
  /// </summary>
  OnScreen = 1
}
