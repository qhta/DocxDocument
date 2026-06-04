namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the BoxStyle enumeration.
/// Used in types such as Box, BoxConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues))]
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

