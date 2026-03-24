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
  /// Specifies the resolution and quality of the exported document.
  /// </summary>
  Print = 0,
  /// <summary>
  /// Specifies the resolution and quality of the exported document.
  /// </summary>
  OnScreen = 1
}
