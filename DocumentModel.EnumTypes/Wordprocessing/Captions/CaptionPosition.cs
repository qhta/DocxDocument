namespace DocumentModel.Wordprocessing;

/// <summary>
///   Automatic Caption Positioning Values
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues))]
public enum CaptionPosition
{
  /// <summary>
  ///   Position Caption Above Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues.Above))]
  Above,

  /// <summary>
  ///   Position Caption Below Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues.Below))]
  Below
}