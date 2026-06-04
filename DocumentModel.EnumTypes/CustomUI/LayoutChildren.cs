namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the LayoutChildren enumeration.
/// Used in types such as LayoutContainer, LayoutContainerConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues))]
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

