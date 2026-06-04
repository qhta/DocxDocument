
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates what the
/// size measurement is in relation to.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlsizerepresents?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlSizeRepresents))]
public enum SizeRepresents
{
  /// <summary>
  /// The size measure is for the width.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlSizeRepresents.xlSizeIsWidth))]
  Width = 2,
  /// <summary>
  /// The size measure is for the area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlSizeRepresents.xlSizeIsArea))]
  Area = 1
}
