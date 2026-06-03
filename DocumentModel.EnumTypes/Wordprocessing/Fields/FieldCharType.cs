namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FieldCharValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FieldCharValues))]
public enum FieldCharType
{
  /// <summary>
  ///   Start Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FieldCharValues.Begin))]
  Begin,
  /// <summary>
  ///   Separator Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FieldCharValues.Separate))]
  Separate,
  /// <summary>
  ///   End Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FieldCharValues.End))]
  End
}