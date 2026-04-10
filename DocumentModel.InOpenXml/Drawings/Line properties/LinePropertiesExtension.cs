namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension for line properties, providing additional configuration or metadata.
/// </summary>
[OpenXmlType(typeof(DXD.LinePropertiesExtension))]
[XmlRoot("LinePropertiesExtension", Namespace = "DocumentModel.Drawings")]
public partial class LinePropertiesExtension : ModelElement<DXD.LinePropertiesExtension>, IExtension
{
 /// <summary>
 ///   Sketch style properties for the line.
 /// </summary>
 public LineSketchStyleProperties? LineSketchStyleProperties { get => _LineSketchStyleProperties; set => UpdateField(ref _LineSketchStyleProperties, value, nameof(LineSketchStyleProperties)); }

 private LineSketchStyleProperties? _LineSketchStyleProperties;
 /// <summary>
 ///  URI associated with the line properties extension.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.LinePropertiesExtension.Uri))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
}