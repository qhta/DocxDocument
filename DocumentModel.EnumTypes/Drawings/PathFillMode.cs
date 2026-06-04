namespace DocumentModel.Drawings;
/// <summary>
///   Path Fill Mode
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PathFillModeValues))]
public enum PathFillMode
{
  /// <summary>
  ///   No Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathFillModeValues.None))]
  None,
  /// <summary>
  ///   Normal Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathFillModeValues.Norm))]
  Norm,
  /// <summary>
  ///   Lighten Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathFillModeValues.Lighten))]
  Lighten,
  /// <summary>
  ///   Lighten Path Fill Less.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathFillModeValues.LightenLess))]
  LightenLess,
  /// <summary>
  ///   Darken Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathFillModeValues.Darken))]
  Darken,
  /// <summary>
  ///   Darken Path Fill Less.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PathFillModeValues.DarkenLess))]
  DarkenLess
}