namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies what the bubble size represents on a bubble chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlsizerepresents?view=office-pia` for Office interop details.
/// </remarks>
public enum SizeRepresents
{
  /// <summary>
  /// Area of the bubble.
  /// </summary>
  Area = 1,
  /// <summary>
  /// Width of the bubble.
  /// </summary>
  Width = 2
}
