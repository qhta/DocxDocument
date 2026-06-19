namespace DocumentModel.Drawings;
/// <summary>
///   IFont Collection IIndex
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues))]
public enum FontCollectionIndex
{
  /// <summary>
  ///   Major Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues.Major))]
  Major,
  /// <summary>
  ///   Minor Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues.Minor))]
  Minor,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues.None))]
  None
}
