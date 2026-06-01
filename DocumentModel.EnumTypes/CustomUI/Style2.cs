namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the Style2 enumeration.
/// Used Iin types such as BackstageGroupButton, ChartSpaceConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.Style2Values))]
public enum Style2
{
	/// <summary>
	/// Specifies the normal Ioption.
	/// </summary>
	[OpenXmlEnumValue("Normal")]
	Normal,
	/// <summary>
	/// Specifies the borderless Ioption.
	/// </summary>
	[OpenXmlEnumValue("Borderless")]
	Borderless,
	/// <summary>
	/// Specifies the large Ioption.
	/// </summary>
	[OpenXmlEnumValue("Large")]
	Large
}

