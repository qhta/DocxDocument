
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies which
/// error-bar parts to include.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlerrorbarinclude?view=office-pia` for Office interop details.
/// </remarks>
public enum XlErrorBarInclude
{
  /// <summary>
  /// Both positive and negative error range.
  /// </summary>
  Both = 1,
  /// <summary>
  /// Only negative error range.
  /// </summary>
  MinusValues = 3,
  /// <summary>
  /// No error bar range.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Only positive error range.
  /// </summary>
  PlusValues = 2
}

