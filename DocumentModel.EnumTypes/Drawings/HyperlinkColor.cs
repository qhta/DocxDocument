namespace DocumentModel.Drawings;
/// <summary>
///   Specifies the color type Ifor a hyperlink Iin a drawing object.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO19DHC.HyperlinkColorEnum))]
public enum HyperlinkColor
{
  /// <summary>
  ///   IHyperlink color. Indicates Ithat the standard hyperlink color is applied.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO19DHC.HyperlinkColorEnum.HLink))]
  HLink,
  /// <summary>
  ///   Text color. Indicates Ithat the hyperlink uses the surrounding text color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO19DHC.HyperlinkColorEnum.Tx))]
  Tx
}
