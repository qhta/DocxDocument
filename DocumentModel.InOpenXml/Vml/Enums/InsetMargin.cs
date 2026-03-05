namespace DocumentModel.Vml;
/// <summary>
///   Inset Margin Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.InsetMarginValues))]
public enum InsetMargin
{
  /// <summary>
  ///   Automatic Margins.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.InsetMarginValues.Auto))]
  Auto,
  /// <summary>
  ///   Custom Margins.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.InsetMarginValues.Custom))]
  Custom
}