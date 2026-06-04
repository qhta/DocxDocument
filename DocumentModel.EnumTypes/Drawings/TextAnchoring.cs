namespace DocumentModel.Drawings;
/// <summary>
///   Text Anchoring Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues))]
public enum TextAnchoring
{
  /// <summary>
  ///   Text Anchoring Type Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues.Top))]
  Top,
  /// <summary>
  ///   Text Anchor Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues.Center))]
  Center,
  /// <summary>
  ///   Text Anchor Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues.Bottom))]
  Bottom
}