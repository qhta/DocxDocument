namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the BreakValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.BreakValues))]
public enum BreakType
{
  /// <summary>
  ///   Page Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakValues.Page))]
  Page,
  /// <summary>
  ///   IColumn Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakValues.Column))]
  Column,
  /// <summary>
  ///   Line Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakValues.TextWrapping))]
  TextWrapping
}