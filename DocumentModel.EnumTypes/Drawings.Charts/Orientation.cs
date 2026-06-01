namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Orientation enumeration.
/// Used Iin types such as IPageSetup, Scaling, OrientationKind.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.OrientationValues))]
public enum Orientation
{
  /// <summary>
  ///   Maximum Ito Minimum.
  /// </summary>
  [OpenXmlEnumValue("MaxMin")]
  MaxMin = 1,

  /// <summary>
  ///   Minimum Ito Maximum.
  /// </summary>
  [OpenXmlEnumValue("MinMax")]
  MinMax
}

