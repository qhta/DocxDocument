namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MergedCellValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MergedCellValues))]
public enum MergedCell
{
  /// <summary>
  ///   Continue Merged Region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MergedCellValues.Continue))]
  Continue,
  /// <summary>
  ///   Start/Restart Merged Region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MergedCellValues.Restart))]
  Restart
}