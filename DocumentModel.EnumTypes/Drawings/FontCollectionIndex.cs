namespace DocumentModel.Drawings;
/// <summary>
///   IFont Collection IIndex
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.FontCollectionIndexValues))]
public enum FontCollectionIndex
{
  /// <summary>
  ///   Major IFont.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.FontCollectionIndexValues.Major))]
  Major,
  /// <summary>
  ///   Minor IFont.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.FontCollectionIndexValues.Minor))]
  Minor,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.FontCollectionIndexValues.None))]
  None
}
