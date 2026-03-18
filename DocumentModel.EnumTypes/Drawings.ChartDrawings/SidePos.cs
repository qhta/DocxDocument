namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the SidePos enumeration.
/// Used in types such as ChartTitle, Legend, SidePos.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SidePos
{
  /// <summary>
  ///   l.
  /// </summary>
  [OpenXmlEnumValue("L")]
  L,
  /// <summary>
  ///   t.
  /// </summary>
  [OpenXmlEnumValue("T")]
  T,
  /// <summary>
  ///   r.
  /// </summary>
  [OpenXmlEnumValue("R")]
  R,
  /// <summary>
  ///   b.
  /// </summary>
  [OpenXmlEnumValue("B")]
  B
}
