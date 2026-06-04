namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ColorApplicationMethod enumeration.
/// Used in types such as ColorsType.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues))]
public enum ColorApplicationMethod
{
  /// <summary>
  ///   Span.
  /// </summary>
  [OpenXmlEnumValue("Span")]
  Span,
  /// <summary>
  ///   Cycle.
  /// </summary>
  [OpenXmlEnumValue("Cycle")]
  Cycle,
  /// <summary>
  ///   Repeat.
  /// </summary>
  [OpenXmlEnumValue("Repeat")]
  Repeat
}

