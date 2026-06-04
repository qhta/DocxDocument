namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocGridValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DocGridValues))]
public enum DocGridType
{
  /// <summary>
  ///   No Document Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocGridValues.Default))]
  Default,
  /// <summary>
  ///   Line Grid Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocGridValues.Lines))]
  Lines,
  /// <summary>
  ///   Line and Character Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocGridValues.LinesAndChars))]
  LinesAndChars,
  /// <summary>
  ///   Character Grid Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocGridValues.SnapToChars))]
  SnapToChars
}