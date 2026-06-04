namespace DocumentModel.Drawings;
/// <summary>
///   ILine End Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.LineEndValues))]
public enum LineEndType
{
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndValues.None))]
  None,
  /// <summary>
  ///   Triangle Arrow Head.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndValues.Triangle))]
  Triangle,
  /// <summary>
  ///   Stealth Arrow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndValues.Stealth))]
  Stealth,
  /// <summary>
  ///   Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndValues.Diamond))]
  Diamond,
  /// <summary>
  ///   Oval.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndValues.Oval))]
  Oval,
  /// <summary>
  ///   Arrow Head.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndValues.Arrow))]
  Arrow
}
