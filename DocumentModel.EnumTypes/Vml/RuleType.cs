namespace DocumentModel.Vml;
/// <summary>
///   Rule Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.RuleValues))]
public enum RuleType
{
  /// <summary>
  ///   Arc Rule.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.RuleValues.Arc))]
  Arc,
  /// <summary>
  ///   Callout Rule.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.RuleValues.Callout))]
  Callout,
  /// <summary>
  ///   Connector Rule.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.RuleValues.Connector))]
  Connector
}