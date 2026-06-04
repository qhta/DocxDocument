namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues))]
public enum SectionStart
{
  /// <summary>
  ///   Next Page ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues.NextPage))]
  NextPage,
  /// <summary>
  ///   Column Section Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues.NextColumn))]
  NextColumn,
  /// <summary>
  ///   Continuous ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues.Continuous))]
  Continuous,
  /// <summary>
  ///   Even Page ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues.EvenPage))]
  EvenPage,
  /// <summary>
  ///   Odd Page ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues.OddPage))]
  OddPage
}