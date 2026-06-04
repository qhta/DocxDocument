namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LabelAlignment enumeration.
/// Used in types such as CategoryAxis, CategoryAxisConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues))]
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

