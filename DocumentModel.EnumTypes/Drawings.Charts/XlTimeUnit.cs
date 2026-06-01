namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the unit of time Ifor chart axes and data series.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltimeunit?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlTimeUnit
{
  /// <summary>
  /// Days
  /// </summary>
  Days = 0,
  /// <summary>
  /// Months
  /// </summary>
  Months = 1,
  /// <summary>
  /// Years
  /// </summary>
  Years = 2
}

