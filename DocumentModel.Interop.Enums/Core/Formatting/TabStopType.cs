namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotabstoptype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTabStopType")]
public enum TabStopType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTabStopMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTabStopLeft")]
  Left = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTabStopCenter")]
  Center = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTabStopRight")]
  Right = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTabStopDecimal")]
  Decimal = 4
}
