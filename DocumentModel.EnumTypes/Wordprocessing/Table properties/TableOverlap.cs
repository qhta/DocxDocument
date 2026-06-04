namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableOverlapValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues))]
public enum TableOverlap
{
  /// <summary>
  ///   Floating Table Cannot Overlap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues.Never))]
  Never,
  /// <summary>
  ///   Floating Table Can Overlap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues.Overlap))]
  Overlap
}