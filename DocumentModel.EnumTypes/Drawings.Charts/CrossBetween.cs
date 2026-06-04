namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CrossBetween enumeration.
/// Used in types such as ValueAxis, ValueAxisConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues))]
public enum CrossBetween
{
  /// <summary>
  ///   Between.
  /// </summary>
  [OpenXmlEnumValue("Between")]
  Between,
  /// <summary>
  ///   Midpoint of ICategory.
  /// </summary>
  [OpenXmlEnumValue("MidpointCategory")]
  MidpointCategory
}

