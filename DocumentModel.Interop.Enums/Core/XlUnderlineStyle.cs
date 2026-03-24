
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
public enum XlUnderlineStyle
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
  /// of underline applied to a font.
  /// </summary>
  Double = -4119,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
  /// of underline applied to a font.
  /// </summary>
  DoubleAccounting = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
  /// of underline applied to a font.
  /// </summary>
  None = -4142,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Single underlining.
  /// xlUnderlineStyleSingleAccounting4 You should access and use this enumeration from the Excel primary interop
  /// assembly (PIA). Not supported. xlUnderlineStyleDoubleAccounting5 You should access and use this enumeration
  /// from the Excel primary interop assembly (PIA). Two thin underlines placed close together.
  /// </summary>
  Single = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
  /// of underline applied to a font.
  /// </summary>
  SingleAccounting = 4
}
