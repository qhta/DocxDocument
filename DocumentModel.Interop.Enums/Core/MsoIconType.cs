namespace DocumentModel.Interop.Core;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoicontype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoIconType))]
public enum IconType
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconNone))]
  None = 0,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconAlert))]
  Alert = 2,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconTip))]
  Tip = 3,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconAlertInfo))]
  AlertInfo = 4,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconAlertWarning))]
  AlertWarning = 5,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconAlertQuery))]
  AlertQuery = 6,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoIconType.msoIconAlertCritical))]
  AlertCritical = 7
}
