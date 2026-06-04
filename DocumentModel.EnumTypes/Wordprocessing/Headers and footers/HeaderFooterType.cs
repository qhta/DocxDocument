namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Header/Footer kind enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues))]
public enum HeaderFooterType
{
  /// <summary>
  ///   Even Numbered Pages Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues.Even))]
  Even,
  /// <summary>
  ///   Default Header or Footer.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues.Default))]
  Default,
  /// <summary>
  ///   First Page Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues.First))]
  First
}