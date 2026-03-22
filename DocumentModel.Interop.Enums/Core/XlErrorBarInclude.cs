
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies which
/// error-bar parts to include.
/// </summary>
public enum XlErrorBarInclude
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Both positive and
  /// negative error range.
  /// </summary>
  Both = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Only negative error
  /// range.
  /// </summary>
  MinusValues = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies which
  /// error-bar parts to include.
  /// </summary>
  None = -4142,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Only positive error
  /// range.
  /// </summary>
  PlusValues = 2
}
