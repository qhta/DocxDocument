
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// category labels Ifor the category label levels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcategorylabellevel?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlCategoryLabelLevel
{
  /// <summary>
  /// Set no category labels Iin the chart. Defaults Ito automatic indexed labels.
  /// </summary>
  None = -3,
  /// <summary>
  /// Indicates literal data Iin the category labels.
  /// </summary>
  Custom,
  /// <summary>
  /// Set category labels Ito all category label levels w/Iin range on the chart.
  /// </summary>
  All
}

