namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ParentLabelLayoutVal enumeration.
/// Used in types such as ParentLabelLayout, ParentLabelLayoutVal, ParentLabelLayoutConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ParentLabelLayoutVal
{
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   banner.
  /// </summary>
  [OpenXmlEnumValue("Banner")]
  Banner,
  /// <summary>
  ///   overlapping.
  /// </summary>
  [OpenXmlEnumValue("Overlapping")]
  Overlapping
}
