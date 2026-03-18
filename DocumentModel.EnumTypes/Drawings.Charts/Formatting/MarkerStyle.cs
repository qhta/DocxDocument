namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MarkerStyle enumeration.
/// Used in types such as MarkerLayoutProperties, MarkerStyle, Marker.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.MarkerStyleValues))]
public enum MarkerStyle
{
  /// <summary>
  ///   auto.
  /// </summary>
  [OpenXmlEnumValue("Auto")]
  Auto,
  /// <summary>
  ///   Circle.
  /// </summary>
  [OpenXmlEnumValue("Circle")]
  Circle,
  /// <summary>
  ///   Dash.
  /// </summary>
  [OpenXmlEnumValue("Dash")]
  Dash,
  /// <summary>
  ///   Diamond.
  /// </summary>
  [OpenXmlEnumValue("Diamond")]
  Diamond,
  /// <summary>
  ///   Dot.
  /// </summary>
  [OpenXmlEnumValue("Dot")]
  Dot,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   Picture.
  /// </summary>
  [OpenXmlEnumValue("Picture")]
  Picture,
  /// <summary>
  ///   Plus.
  /// </summary>
  [OpenXmlEnumValue("Plus")]
  Plus,
  /// <summary>
  ///   Square.
  /// </summary>
  [OpenXmlEnumValue("Square")]
  Square,
  /// <summary>
  ///   Star.
  /// </summary>
  [OpenXmlEnumValue("Star")]
  Star,
  /// <summary>
  ///   Triangle.
  /// </summary>
  [OpenXmlEnumValue("Triangle")]
  Triangle,
  /// <summary>
  ///   X.
  /// </summary>
  [OpenXmlEnumValue("X")]
  X
}
