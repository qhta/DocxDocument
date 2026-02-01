namespace DocumentModel.Drawings;
/// <summary>
///   Font Collection Index
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.FontCollectionIndexValues))]
public enum FontCollectionIndexKind
{
  /// <summary>
  ///   Major Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.FontCollectionIndexValues.Major))]
  Major,
  /// <summary>
  ///   Minor Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.FontCollectionIndexValues.Minor))]
  Minor,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.FontCollectionIndexValues.None))]
  None
}