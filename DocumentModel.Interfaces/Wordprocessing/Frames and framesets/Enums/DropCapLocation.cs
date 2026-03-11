namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DropCapLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DropCapLocationValues))]
public enum DropCapLocation
{
  /// <summary>
  ///   No Drop Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DropCapLocationValues.None))]
  None,
  /// <summary>
  ///   Drop Cap Inside Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DropCapLocationValues.Drop))]
  Drop,
  /// <summary>
  ///   Drop Cap Outside Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DropCapLocationValues.Margin))]
  Margin
}