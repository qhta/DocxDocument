namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LayoutTarget enumeration.
/// Used in types such as ManualLayout, ManualLayoutConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues))]
public enum LayoutTarget
{
  /// <summary>
  ///   Inner.
  /// </summary>
  [OpenXmlEnumValue("Inner")]
  Inner,
  /// <summary>
  ///   Outer.
  /// </summary>
  [OpenXmlEnumValue("Outer")]
  Outer
}

