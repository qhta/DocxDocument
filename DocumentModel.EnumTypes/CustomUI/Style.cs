namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the Style enumeration.
/// Used in types such as DocumentCleaner, BackstageGroup, BackstageGroupButton.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.StyleValues))]
public enum Style
{
	/// <summary>
	/// Specifies the normal option.
	/// </summary>
	[OpenXmlEnumValue("Normal")]
	Normal,
	/// <summary>
	/// Specifies the warning option.
	/// </summary>
	[OpenXmlEnumValue("Warning")]
	Warning,
	/// <summary>
	/// Specifies the error option.
	/// </summary>
	[OpenXmlEnumValue("Error")]
	Error
}
