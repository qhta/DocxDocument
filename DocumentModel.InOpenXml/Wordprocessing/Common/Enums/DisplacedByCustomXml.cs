namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DisplacedByCustomXmlValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DisplacedByCustomXmlValues))]
public enum DisplacedByCustomXml
{
  /// <summary>
  ///   Displaced by Next Custom XML Markup Tag.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DisplacedByCustomXmlValues.Next))]
  Next,
  /// <summary>
  ///   Displaced by Previous Custom XML Markup Tag.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DisplacedByCustomXmlValues.Previous))]
  Previous
}