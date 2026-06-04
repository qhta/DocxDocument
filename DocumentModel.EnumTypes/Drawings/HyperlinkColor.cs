namespace DocumentModel.Drawings;
/// <summary>
///   Specifies the color type for a hyperlink in a drawing object.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum))]
public enum HyperlinkColor
{
  /// <summary>
  ///   IHyperlink color. Indicates Ithat the standard hyperlink color is applied.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum.HLink))]
  HLink,
  /// <summary>
  ///   Text color. Indicates Ithat the hyperlink uses the surrounding text color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum.Tx))]
  Tx
}
