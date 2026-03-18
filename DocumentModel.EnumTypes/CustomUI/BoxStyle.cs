namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the BoxStyle enumeration.
/// Used in types such as Box, BoxConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.BoxStyleValues))]
public enum BoxStyle
{
  /// <summary>
  /// Box is horizontal.
  /// </summary>
  [OpenXmlEnumValue("Horizontal")]
	Horizontal,
	/// <summary>
	/// Box is vertical.
	/// </summary>
	[OpenXmlEnumValue("Vertical")]
	Vertical
}
