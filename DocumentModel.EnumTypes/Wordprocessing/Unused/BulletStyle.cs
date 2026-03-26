namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BulletStyle enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum BulletStyle
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>Solid round bullet</summary>
  [OpenXmlEnumValue("Bullet")]
  Bullet = 0,
  /// <summary>Open circle bullet</summary>
  [OpenXmlEnumValue("Circle")]
  Circle = 1,
  /// <summary>Solid square bullet</summary>
  [OpenXmlEnumValue("Square")]
  Square = 2,
  /// <summary>Diamond bullet</summary>
  [OpenXmlEnumValue("Diamond")]
  Diamond = 3,
  /// <summary>Arrow bullet</summary>
  [OpenXmlEnumValue("Arrow")]
  Arrow = 4,
  /// <summary>Check mark bullet</summary>
  [OpenXmlEnumValue("Check")]
  Check = 5
}
