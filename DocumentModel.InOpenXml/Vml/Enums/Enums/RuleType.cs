namespace DocumentModel.Vml;
/// <summary>
///   Rule Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.RuleValues))]
public enum RuleType
{
  /// <summary>
  ///   Arc Rule.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.RuleValues.Arc))]
  Arc,
  /// <summary>
  ///   Callout Rule.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.RuleValues.Callout))]
  Callout,
  /// <summary>
  ///   Connector Rule.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.RuleValues.Connector))]
  Connector
}