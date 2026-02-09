namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageBorderZOrderValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.PageBorderZOrderValues))]
public enum PageBorderZOrder
{
  /// <summary>
  ///   Page Border Ahead of Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderZOrderValues.Front))]
  Front,
  /// <summary>
  ///   Page Border Behind Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderZOrderValues.Back))]
  Back
}