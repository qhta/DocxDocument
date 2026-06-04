namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Orientation enumeration.
/// Used in types such as IPageSetup, Scaling, OrientationKind.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.OrientationValues))]
public enum Orientation
{
  /// <summary>
  ///   Maximum to Minimum.
  /// </summary>
  [OpenXmlEnumValue("MaxMin")]
  MaxMin = 1,

  /// <summary>
  ///   Minimum to Maximum.
  /// </summary>
  [OpenXmlEnumValue("MinMax")]
  MinMax
}

