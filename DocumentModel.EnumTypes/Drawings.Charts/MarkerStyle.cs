namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Specifies the marker style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues))]
public enum MarkerStyle
{
  /// <summary>
  /// Automatic marker style.
  /// The actual marker style is determined by the chart type and the order of the data series in the chart.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Auto))]
  Automatic = -4105,

  /// <summary>
  /// Square markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Square))]
  Square = 1,

  /// <summary>
  /// Diamond-shaped markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Diamond))]
  Diamond = 2,

  /// <summary>
  /// Triangular markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Triangle))]
  Triangle = 3,

  /// <summary>
  /// Square markers with  an asterisk.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Star))]
  Star = 5,

  /// <summary>
  /// Circular markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Circle))]
  Circle = 8,

  /// <summary>
  /// Square markers with a plus sign.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Plus))]
  Plus = 9,

  /// <summary>
  /// Long-bar markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Dash))]
  Dash = -4115,

  /// <summary>
  /// Short-bar markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Dot))]
  Dot = -4118,

  /// <summary>
  /// No markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.None))]
  None = -4142,

  /// <summary>
  /// Picture markers.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.Picture))]
  Picture = -4147,

  /// <summary>
  /// Square markers with X.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues.X))]
  X = -4168,
}
