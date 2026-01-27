namespace DocumentModel.Drawings;
/// <summary>
///   Defines a list of custom colors for drawing elements in a DrawingML theme, enabling advanced color customization for shapes, text, and backgrounds.
///   Supports extensibility through an extension list for application-specific or future color data.
/// </summary>
[OpenXmlType(typeof(CustomColor))]
public partial class CustomColorList : ModelElementCollection<CustomColor, DXD.CustomColorList, DXD.CustomColor>, IExtendableElement
{
  /// <summary>
  ///   List of extension elements for the custom color list, allowing for future extensibility and application-specific color data.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
