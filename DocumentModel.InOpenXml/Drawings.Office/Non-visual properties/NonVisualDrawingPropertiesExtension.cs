using DocumentModel.Drawings.Office.ScriptLink;

namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for non-visual drawing properties, providing additional metadata and configuration options.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualDrawingPropertiesExtension))]
public partial class NonVisualDrawingPropertiesExtension:
  NonVisualDrawingProperties<DXD.NonVisualDrawingPropertiesExtension>, IExtension
{
  public string? Uri { get; set; }
}