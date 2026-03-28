namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelPos enumeration.
/// Used in types such as DataLabel, DataLabels, DataLabelPos.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DataLabelPos
{
  /// <summary>
  ///   bestFit.
  /// </summary>
  [OpenXmlEnumValue("BestFit")]
  BestFit = 1,

  /// <summary>
  ///   b.
  /// </summary>
  [OpenXmlEnumValue("B")]
  B,
  /// <summary>
  ///   ctr.
  /// </summary>
  [OpenXmlEnumValue("Ctr")]
  Ctr,
  /// <summary>
  ///   inBase.
  /// </summary>
  [OpenXmlEnumValue("InBase")]
  InBase,
  /// <summary>
  ///   inEnd.
  /// </summary>
  [OpenXmlEnumValue("InEnd")]
  InEnd,
  /// <summary>
  ///   l.
  /// </summary>
  [OpenXmlEnumValue("L")]
  L,
  /// <summary>
  ///   outEnd.
  /// </summary>
  [OpenXmlEnumValue("OutEnd")]
  OutEnd,
  /// <summary>
  ///   r.
  /// </summary>
  [OpenXmlEnumValue("R")]
  R,
  /// <summary>
  ///   t.
  /// </summary>
  [OpenXmlEnumValue("T")]
  T
}
