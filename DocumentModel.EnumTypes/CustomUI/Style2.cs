namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the Style2 enumeration.
/// Used in types such as BackstageGroupButton, ChartSpaceConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.Style2Values))]
public enum Style2
{
	/// <summary>
	/// Specifies the normal option.
	/// </summary>
	[OpenXmlEnumValue("Normal")]
	Normal,
	/// <summary>
	/// Specifies the borderless option.
	/// </summary>
	[OpenXmlEnumValue("Borderless")]
	Borderless,
	/// <summary>
	/// Specifies the large option.
	/// </summary>
	[OpenXmlEnumValue("Large")]
	Large
}
