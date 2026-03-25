
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates the
/// position of data labels relative to the data markers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldatalabelposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlDataLabelPosition
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label centered
  /// on data point or inside bar or pie.
  /// </summary>
  Center = -4108,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned above point.
  /// </summary>
  Above = 0,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned below point.
  /// </summary>
  Below = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned at bottom of bar or pie.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned at top of bar or pie.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned at top of bar or pie.
  /// </summary>
  OutsideEnd = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned arbitrarily.
  /// </summary>
  InsideEnd = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned arbitrarily.
  /// </summary>
  InsideBase = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Office application
  /// controls position of data label.
  /// </summary>
  BestFit = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label
  /// positioned at bottom of bar or pie.
  /// </summary>
  Mixed = 6,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data label centered
  /// on data point or inside bar or pie.
  /// </summary>
  Custom = 7
}
