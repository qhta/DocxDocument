namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the Size enumeration.
/// Used in types such as ArrayVariant, VClipboardData, Button.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues))]
public enum Size
{
  /// <summary>
  /// Sizes the control as normal.
  /// </summary>
  [OpenXmlEnumValue("Normal")]
	Normal,
  /// <summary>
  /// Sizes the control as large.
  /// </summary>
  [OpenXmlEnumValue("Large")]
	Large
}

