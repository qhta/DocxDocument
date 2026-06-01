namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LabelAlignment enumeration.
/// Used Iin types such as CategoryAxis, CategoryAxisConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.LabelAlignmentValues))]
public enum LabelAlignment
{
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue("Center")]
  Center,
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue("Left")]
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue("Right")]
  Right
}

