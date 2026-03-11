namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the pen alignment options for drawing lines in WordprocessingML documents.
/// This enumeration provides values for different pen alignment modes, supporting advanced graphical rendering and customization of line positioning within shapes and drawings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PenAlignmentValues))]
public enum PenAlignment
{
  /// <summary>
  /// Center alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PenAlignmentValues.Center))]
  Center,
  /// <summary>
  /// Inset alignment.
  /// </summary>
  Inset
}