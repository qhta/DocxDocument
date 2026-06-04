
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the scale
/// type of the value axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlscaletype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlScaleType")]
public enum ScaleType
{
  /// <summary>
  /// Linear.
  /// </summary>
  [InteropEnumValue("xlScaleLinear")]
  Linear = -4132,
  /// <summary>
  /// Logarithmic.
  /// </summary>
  [InteropEnumValue("xlScaleLogarithmic")]
  Logarithmic = -4133
}
