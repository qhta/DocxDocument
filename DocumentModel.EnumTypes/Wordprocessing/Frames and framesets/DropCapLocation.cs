namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DropCapLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues))]
public enum DropCapLocation
{
  /// <summary>
  ///   Not Drop Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues.None))]
  None,
  /// <summary>
  ///   Drop Cap Inside Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues.Drop))]
  Drop,
  /// <summary>
  ///   Drop Cap Outside Margin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues.Margin))]
  Margin
}