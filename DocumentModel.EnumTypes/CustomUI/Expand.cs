namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the Expand enumeration.
/// Used in types such as BackstageCheckBox, BackstageComboBox, BackstageDropDown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.ExpandValues))]
public enum Expand
{
	/// <summary>
	/// Expand from top left.
	/// </summary>
	[OpenXmlEnumValue("TopLeft")]
	TopLeft,
	/// <summary>
	/// Expand from top.
	/// </summary>
	[OpenXmlEnumValue("Top")]
	Top,
	/// <summary>
	/// Expand from top right.
	/// </summary>
	[OpenXmlEnumValue("TopRight")]
	TopRight,
	/// <summary>
	/// Expand from left.
	/// </summary>
	[OpenXmlEnumValue("Left")]
	Left,
	/// <summary>
	/// Expand from center.
	/// </summary>
	[OpenXmlEnumValue("Center")]
	Center,
	/// <summary>
	/// Expand from right.
	/// </summary>
	[OpenXmlEnumValue("Right")]
	Right,
	/// <summary>
	/// Expand from bottom left.
	/// </summary>
	[OpenXmlEnumValue("BottomLeft")]
	BottomLeft,
	/// <summary>
	/// Expand from bottom.
	/// </summary>
	[OpenXmlEnumValue("Bottom")]
	Bottom,
	/// <summary>
	/// Expand from bottom right.
	/// </summary>
	[OpenXmlEnumValue("BottomRight")]
	BottomRight
}

