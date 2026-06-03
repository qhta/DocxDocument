namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the Size enumeration.
/// Used in types such as ArrayVariant, VClipboardData, Button.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.SizeValues))]
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

