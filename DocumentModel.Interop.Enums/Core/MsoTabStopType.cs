namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotabstoptype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTabStopType")]
public enum TabStopType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTabStopMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTabStopLeft")]
  Left = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTabStopCenter")]
  Center = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTabStopRight")]
  Right = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTabStopDecimal")]
  Decimal = 4
}
