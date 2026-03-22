namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the size of the angle between the callout line and the side of the callout text box.
/// </summary>
public enum MsoCalloutAngleType
{
  /// <summary>
  /// Specifies the size of the angle between the callout line and the side of the callout text box.
  /// </summary>
  msoCalloutAngleMixed = -2,
  /// <summary>
  /// Specifies the size of the angle between the callout line and the side of the callout text box.
  /// </summary>
  msoCalloutAngleAutomatic = 1,
  /// <summary>
  /// 30˚ angle.
  /// </summary>
  msoCalloutAngle30 = 2,
  /// <summary>
  /// 45˚ angle.
  /// </summary>
  msoCalloutAngle45 = 3,
  /// <summary>
  /// 60˚ angle.
  /// </summary>
  msoCalloutAngle60 = 4,
  /// <summary>
  /// 90˚ angle.
  /// </summary>
  msoCalloutAngle90 = 5
}
