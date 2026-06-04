namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalertcanceltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoAlertCancelType))]
public enum AlertCancelType
{
  /// <summary>
  /// Default behavior for canceling an alert.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlertCancelType.msoAlertCancelDefault))]
  Default = -1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlertCancelType.msoAlertCancelFirst))]
  First,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlertCancelType.msoAlertCancelSecond))]
  Second,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlertCancelType.msoAlertCancelThird))]
  Third,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlertCancelType.msoAlertCancelFourth))]
  Fourth,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlertCancelType.msoAlertCancelFifth))]
  Fifth
}
