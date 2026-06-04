namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalMergeRevisionValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues))]
public enum VerticalMergeRevision
{
  /// <summary>
  ///   Vertically Merged Cell.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues.Continue))]
  Continue,
  /// <summary>
  ///   Vertically Split Cell.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues.Restart))]
  Restart
}