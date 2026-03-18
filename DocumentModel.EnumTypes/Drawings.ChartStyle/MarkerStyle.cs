namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the MarkerStyle enumeration.
/// Used in types such as MarkerLayoutProperties, MarkerStyle, Marker.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.MarkerStyleValues))]
public enum MarkerStyle
{
  /// <summary>
  ///   circle.
  /// </summary>
  [OpenXmlEnumValue("Circle")]
  Circle,
  /// <summary>
  ///   dash.
  /// </summary>
  [OpenXmlEnumValue("Dash")]
  Dash,
  /// <summary>
  ///   diamond.
  /// </summary>
  [OpenXmlEnumValue("Diamond")]
  Diamond,
  /// <summary>
  ///   dot.
  /// </summary>
  [OpenXmlEnumValue("Dot")]
  Dot,
  /// <summary>
  ///   plus.
  /// </summary>
  [OpenXmlEnumValue("Plus")]
  Plus,
  /// <summary>
  ///   square.
  /// </summary>
  [OpenXmlEnumValue("Square")]
  Square,
  /// <summary>
  ///   star.
  /// </summary>
  [OpenXmlEnumValue("Star")]
  Star,
  /// <summary>
  ///   triangle.
  /// </summary>
  [OpenXmlEnumValue("Triangle")]
  Triangle,
  /// <summary>
  ///   x.
  /// </summary>
  [OpenXmlEnumValue("X")]
  X
}
