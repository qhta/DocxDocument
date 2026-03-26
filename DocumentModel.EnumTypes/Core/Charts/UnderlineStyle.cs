
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
public enum UnderlineStyle
{
  /// <summary>
  /// Double thick underline.
  /// </summary>
  Double = -4119,
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  DoubleAccounting = 5,
  /// <summary>
  /// No underlining.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Single underlining.
  /// </summary>
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  SingleAccounting = 4
}
