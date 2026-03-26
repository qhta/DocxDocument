
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
public enum HAlign
{
  /// <summary>
  /// Center.
  /// </summary>
  Center = -4108,
  /// <summary>
  /// Center across selection.
  /// </summary>
  CenterAcrossSelection = 7,
  /// <summary>
  /// Distribute.
  /// </summary>
  Distributed = -4117,
  /// <summary>
  /// Fill.
  /// </summary>
  Fill = 5,
  /// <summary>
  /// Align according to data type.
  /// </summary>
  General = 1,
  /// <summary>
  /// Justify.
  /// </summary>
  Justify = -4130,
  /// <summary>
  /// Left.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Right.
  /// </summary>
  Right = -4152
}
