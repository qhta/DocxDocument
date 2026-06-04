namespace DocumentModel.Math;
/// <summary>
///   Defines the BooleanValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.BooleanValues))]
public enum Boolean
{
  /// <summary>
  ///   true.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BooleanValues.True))]
  True,
  /// <summary>
  ///   false.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BooleanValues.False))]
  False,
  /// <summary>
  ///   On.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BooleanValues.On))]
  On,
  /// <summary>
  ///   Off.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BooleanValues.Off))]
  Off,
  /// <summary>
  ///   0.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BooleanValues.Zero))]
  Zero,
  /// <summary>
  ///   1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BooleanValues.One))]
  One
}