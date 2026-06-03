namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the IStyle enumeration.
/// Used in types such as DocumentCleaner, BackstageGroup, BackstageGroupButton.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.StyleValues))]
public enum Style
{
	/// <summary>
	/// Specifies the normal Ioption.
	/// </summary>
	[OpenXmlEnumValue("Normal")]
	Normal,
	/// <summary>
	/// Specifies the warning Ioption.
	/// </summary>
	[OpenXmlEnumValue("Warning")]
	Warning,
	/// <summary>
	/// Specifies the error Ioption.
	/// </summary>
	[OpenXmlEnumValue("Error")]
	Error
}

