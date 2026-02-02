namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableWidthValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableWidthValues))]
public enum TableWidth
{
  /// <summary>
  ///   nil.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableWidthValues.Nil))]
  Nil,
  /// <summary>
  ///   val.
  /// </summary>
  Twips
}