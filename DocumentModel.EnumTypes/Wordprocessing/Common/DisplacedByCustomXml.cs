namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DisplacedByCustomXmlValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues))]
public enum DisplacedByCustomXml
{
  /// <summary>
  ///   Displaced by Next Custom XML Markup Tag.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues.Next))]
  Next,
  /// <summary>
  ///   Displaced by Previous Custom XML Markup Tag.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues.Previous))]
  Previous
}