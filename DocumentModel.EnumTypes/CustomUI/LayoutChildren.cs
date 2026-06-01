namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the LayoutChildren enumeration.
/// Used Iin types such as LayoutContainer, LayoutContainerConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.LayoutChildrenValues))]
public enum LayoutChildren
{
  /// <summary>
  /// Children are laid out horizontally.
  /// </summary>
  [OpenXmlEnumValue("Horizontal")]
	Horizontal,
	/// <summary>
	/// Children are laid out vertically.
	/// </summary>
	[OpenXmlEnumValue("Vertical")]
	Vertical
}

