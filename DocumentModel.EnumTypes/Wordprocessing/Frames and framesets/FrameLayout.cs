namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FrameLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FrameLayoutValues))]
public enum FrameLayout
{
  /// <summary>
  ///   Stack Frames Vertically.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FrameLayoutValues.Rows))]
  Rows,
  /// <summary>
  ///   Stack Frames Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FrameLayoutValues.Columns))]
  Columns,
  /// <summary>
  ///   Do Not Stack Frames.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FrameLayoutValues.None))]
  None
}