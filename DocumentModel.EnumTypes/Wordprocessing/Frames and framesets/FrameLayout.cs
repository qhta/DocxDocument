namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FrameLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues))]
public enum FrameLayout
{
  /// <summary>
  ///   Stack Frames Vertically.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues.Rows))]
  Rows,
  /// <summary>
  ///   Stack Frames Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues.Columns))]
  Columns,
  /// <summary>
  ///   Do Not Stack Frames.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues.None))]
  None
}