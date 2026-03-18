namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SortOrder enumeration.
/// Used in types such as Bibliography, Bibliography.ShouldSerialize.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum SortOrder
{
  /// <summary>Ascending order</summary>
  [OpenXmlEnumValue("Ascending")]
  Ascending,
  /// <summary>Descending order</summary>
  [OpenXmlEnumValue("Descending")]
  Descending
}
