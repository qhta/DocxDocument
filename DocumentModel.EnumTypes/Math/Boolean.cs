namespace DocumentModel.Math;
/// <summary>
///   Defines the BooleanValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.BooleanValues))]
public enum Boolean
{
  /// <summary>
  ///   true.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BooleanValues.True))]
  True,
  /// <summary>
  ///   false.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BooleanValues.False))]
  False,
  /// <summary>
  ///   On.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BooleanValues.On))]
  On,
  /// <summary>
  ///   Off.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BooleanValues.Off))]
  Off,
  /// <summary>
  ///   0.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BooleanValues.Zero))]
  Zero,
  /// <summary>
  ///   1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BooleanValues.One))]
  One
}