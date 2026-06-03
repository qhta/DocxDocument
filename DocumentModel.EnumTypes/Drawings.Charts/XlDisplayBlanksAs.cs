namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayblanksas?view=office-pia` for Office interop details.
/// </remarks>
public enum XlDisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  NotPlotted = 1,
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  Zero = 2,
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  Interpolated = 3
}

