
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
public enum XlHAlign
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Center.
  /// </summary>
  Center = -4108,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Center across
  /// selection.
  /// </summary>
  CenterAcrossSelection = 7,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Distribute.
  /// </summary>
  Distributed = -4117,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Fill.
  /// </summary>
  Fill = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Align according to
  /// data type.
  /// </summary>
  General = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Justify.
  /// </summary>
  Justify = -4130,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Left.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Right.
  /// </summary>
  Right = -4152
}
