namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the color of a selected feature, such as a border, font, or fill.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlcolorindex?view=office-pia` for Office interop details.
/// </remarks>
public enum ColorIndex
{
  /// <summary>
  /// No color.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Automatic color.
  /// </summary>
  Automatic = -4105
}
