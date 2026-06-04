namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the SdtAppearance enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2013.Word.SdtAppearance))]
public enum SdtAppearance
{
  /// <summary>
  ///   boundingBox.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2013.Word.SdtAppearance.BoundingBox))]
  BoundingBox,
  /// <summary>
  ///   tags.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2013.Word.SdtAppearance.Tags))]
  Tags,
  /// <summary>
  ///   hidden.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2013.Word.SdtAppearance.Hidden))]
  Hidden
}