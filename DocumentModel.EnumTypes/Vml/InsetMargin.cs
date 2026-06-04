namespace DocumentModel.Vml;
/// <summary>
///   Inset Margin Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.InsetMarginValues))]
public enum InsetMargin
{
  /// <summary>
  ///   Automatic Margins.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.InsetMarginValues.Auto))]
  Auto,
  /// <summary>
  ///   Custom Margins.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.InsetMarginValues.Custom))]
  Custom
}