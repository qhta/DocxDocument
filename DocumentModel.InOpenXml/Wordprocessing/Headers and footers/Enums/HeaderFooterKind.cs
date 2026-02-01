namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Header/Footer kind enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.HeaderFooterValues))]
public enum HeaderFooterKind
{
  /// <summary>
  ///   Even Numbered Pages Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HeaderFooterValues.Even))]
  Even,
  /// <summary>
  ///   Default Header or Footer.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HeaderFooterValues.Default))]
  Default,
  /// <summary>
  ///   First Page Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HeaderFooterValues.First))]
  First
}