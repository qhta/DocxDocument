namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the size of the angle between the callout line and the side of the callout text box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutangletype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoCalloutAngleType")]
public enum CalloutAngleType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoCalloutAngleMixed")]
  Mixed = -2,
  /// <summary>
  /// Default angle. Angle can be changed as you drag the object.
  /// </summary>
  [InteropEnumValue("msoCalloutAngleAutomatic")]
  Automatic = 1,
  /// <summary>
  /// 30Ëš angle.
  /// </summary>
  [InteropEnumValue("msoCalloutAngle30")]
  ThirtyDegrees = 2,
  /// <summary>
  /// 45Ëš angle.
  /// </summary>
  [InteropEnumValue("msoCalloutAngle45")]
  FortyFiveDegrees = 3,
  /// <summary>
  /// 60Ëš angle.
  /// </summary>
  [InteropEnumValue("msoCalloutAngle60")]
  SixtyDegrees = 4,
  /// <summary>
  /// 90Ëš angle.
  /// </summary>
  [InteropEnumValue("msoCalloutAngle90")]
  NinetyDegrees = 5
}
