namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalertcanceltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoAlertCancelType")]
public enum AlertCancelType
{
  /// <summary>
  /// Default behavior for canceling an alert.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertCancelDefault")]
  Default = -1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertCancelFirst")]
  First,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertCancelSecond")]
  Second,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertCancelThird")]
  Third,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertCancelFourth")]
  Fourth,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoAlertCancelFifth")]
  Fifth
}
