namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which axis values are to receive error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlerrorbardirection?view=office-pia` for Office interop details.
/// </remarks>
public enum XlErrorBarDirection
{
  /// <summary>
  /// Bars run parallel to the X axis for Y-axis values.
  /// </summary>
  Y = 1,
  /// <summary>
  /// Specifies which axis values are to receive error bars.
  /// </summary>
  X = -4168
}
