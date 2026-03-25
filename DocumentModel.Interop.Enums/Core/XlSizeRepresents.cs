
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates what the
/// size measurement is in relation to.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlsizerepresents?view=office-pia` for Office interop details.
/// </remarks>
public enum XlSizeRepresents
{
  /// <summary>
  /// The size measure is for the width.
  /// </summary>
  Width = 2,
  /// <summary>
  /// The size measure is for the area.
  /// </summary>
  Area = 1
}
