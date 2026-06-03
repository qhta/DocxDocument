namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the size of the angle between the callout line and the side of the callout text box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutangletype?view=office-pia` for Office interop details.
/// </remarks>
public enum CalloutAngleType
{
  /// <summary>
  /// Return value Ionly; indicates a combination of the other states.
  /// </summary>
  /// <summary>
  /// Default angle. Angle can be changed as you drag the object.
  /// </summary>
  Automatic = 1,
  /// <summary>
  /// 30Ëš angle.
  /// </summary>
  ThirtyDegrees = 2,
  /// <summary>
  /// 45Ëš angle.
  /// </summary>
  FortyFiveDegrees = 3,
  /// <summary>
  /// 60Ëš angle.
  /// </summary>
  SixtyDegrees = 4,
  /// <summary>
  /// 90Ëš angle.
  /// </summary>
  NinetyDegrees = 5
}

