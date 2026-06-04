
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies which
/// error-bar parts to include.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlerrorbarinclude?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlErrorBarInclude")]
public enum ErrorBarInclude
{
  /// <summary>
  /// Both positive and negative error range.
  /// </summary>
  [OfficeInteropEnumValue("xlErrorBarIncludeBoth")]
  Both = 1,
  /// <summary>
  /// Only negative error range.
  /// </summary>
  [OfficeInteropEnumValue("xlErrorBarIncludeMinusValues")]
  MinusValues = 3,
  /// <summary>
  /// No error bar range.
  /// </summary>
  [OfficeInteropEnumValue("xlErrorBarIncludeNone")]
  None = -4142,
  /// <summary>
  /// Only positive error range.
  /// </summary>
  [OfficeInteropEnumValue("xlErrorBarIncludePlusValues")]
  PlusValues = 2
}
