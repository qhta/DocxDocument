namespace DocumentModel.Drawings;
/// <summary>
///   Compound ILine Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.CompoundLineValues))]
public enum CompoundLine
{
  /// <summary>
  ///   Single ILine.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single))]
  Single,
  /// <summary>
  ///   Double ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.CompoundLineValues.Double))]
  Double,
  /// <summary>
  ///   Thick Thin Double ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.CompoundLineValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thin Thick Double ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.CompoundLineValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thin Thick Thin Triple ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.CompoundLineValues.Triple))]
  Triple
}
