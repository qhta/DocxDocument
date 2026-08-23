namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the ItemSize enumeration.
/// Used in types such as BackstageMenuGroup, Menu, MenuRegular.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues))]
public enum ItemSize
{
  /// <summary>
  /// Item size is normal.
  /// </summary>
  [OpenXmlEnumValue("Normal")]
  Normal,
  /// <summary>
  /// Item size is large.
  /// </summary>
  [OpenXmlEnumValue("Large")]
  Large
}

