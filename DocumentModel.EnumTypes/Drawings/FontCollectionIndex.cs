namespace DocumentModel.Drawings;
/// <summary>
///   IFont Collection IIndex
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues))]
public enum FontCollectionIndex
{
  /// <summary>
  ///   Major IFont.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues.Major))]
  Major,
  /// <summary>
  ///   Minor IFont.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues.Minor))]
  Minor,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues.None))]
  None
}
