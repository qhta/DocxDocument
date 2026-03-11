namespace DocumentModel.Drawings;
/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PenAlignmentValues))]
public enum PenAlignment
{
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PenAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Inset Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PenAlignmentValues.Insert))]
  Insert
}