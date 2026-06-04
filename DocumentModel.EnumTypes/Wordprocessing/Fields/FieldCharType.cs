namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FieldCharValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldCharValues))]
public enum FieldCharType
{
  /// <summary>
  ///   Start Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FieldCharValues.Begin))]
  Begin,
  /// <summary>
  ///   Separator Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FieldCharValues.Separate))]
  Separate,
  /// <summary>
  ///   End Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FieldCharValues.End))]
  End
}