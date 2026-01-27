using DocumentModel.Drawings.Office.ScriptLink;

namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension element for non-visual drawing properties in DrawingML/Office, providing additional metadata and configuration options for shapes, images, or graphical objects.
///   Enables extensibility for custom or future Office features by associating extra data with non-visual drawing properties.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualDrawingPropertiesExtension))]
public partial class NonVisualDrawingPropertiesExtension :
  NonVisualDrawingProperties<DXD.NonVisualDrawingPropertiesExtension>, IExtension
{
  /// <summary>
  ///   URI string identifying the extension type or schema for the non-visual drawing properties extension.
  /// </summary>
  public string? Uri { get; set; }
}
