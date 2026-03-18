namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LayoutTarget enumeration.
/// Used in types such as ManualLayout, ManualLayoutConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.LayoutTargetValues))]
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
