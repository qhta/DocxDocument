namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the size of the angle between the callout line and the side of the callout text box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutangletype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoCalloutAngleType))]
public enum CalloutAngleType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCalloutAngleType.msoCalloutAngleMixed))]
  Mixed = -2,
  /// <summary>
  /// Default angle. Angle can be changed as you drag the object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCalloutAngleType.msoCalloutAngleAutomatic))]
  Automatic = 1,
  /// <summary>
  /// 30Ëš angle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCalloutAngleType.msoCalloutAngle30))]
  ThirtyDegrees = 2,
  /// <summary>
  /// 45Ëš angle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCalloutAngleType.msoCalloutAngle45))]
  FortyFiveDegrees = 3,
  /// <summary>
  /// 60Ëš angle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCalloutAngleType.msoCalloutAngle60))]
  SixtyDegrees = 4,
  /// <summary>
  /// 90Ëš angle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCalloutAngleType.msoCalloutAngle90))]
  NinetyDegrees = 5
}
