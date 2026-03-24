namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of horizontal text set within vertical text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontalinverticaltype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdHorizontalInVerticalType
{
  /// <summary>
  /// Specifies the format of horizontal text set within vertical text.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies the format of horizontal text set within vertical text.
  /// </summary>
  FitInLine = 1,
  /// <summary>
  /// Specifies the format of horizontal text set within vertical text.
  /// </summary>
  ResizeLine = 2
}
