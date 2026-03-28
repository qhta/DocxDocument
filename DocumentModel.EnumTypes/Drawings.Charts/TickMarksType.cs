namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TickMarksType enumeration.
/// Used in types such as OpenXmlTickMarksElement, TickMarksType, OpenXmlTickMarksElementConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TickMarksType
{
  /// <summary>
  ///   in.
  /// </summary>
  [OpenXmlEnumValue("In")]
  In,
  /// <summary>
  ///   out.
  /// </summary>
  [OpenXmlEnumValue("Out")]
  Out,
  /// <summary>
  ///   cross.
  /// </summary>
  [OpenXmlEnumValue("Cross")]
  Cross,
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None
}
