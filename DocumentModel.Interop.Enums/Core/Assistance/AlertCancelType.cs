namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalertcanceltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoAlertCancelType")]
public enum AlertCancelType
{
  /// <summary>
  /// Default behavior for canceling an alert.
  /// </summary>
  [InteropEnumValue("msoAlertCancelDefault")]
  Default = -1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoAlertCancelFirst")]
  First,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoAlertCancelSecond")]
  Second,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoAlertCancelThird")]
  Third,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoAlertCancelFourth")]
  Fourth,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoAlertCancelFifth")]
  Fifth
}
