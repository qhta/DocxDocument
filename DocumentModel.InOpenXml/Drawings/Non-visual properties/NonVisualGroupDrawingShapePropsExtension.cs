namespace DocumentModel.Drawings;
/// <summary>
///   Defines an extension for non-visual group drawing shape properties, allowing for additional metadata or properties to be associated with group shapes.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualGroupDrawingShapePropsExtension))]
public partial class NonVisualGroupDrawingShapePropsExtension : ModelElement<DXD.NonVisualGroupDrawingShapePropsExtension>, IExtension
{
 public NonVisualGroupProperties? NonVisualGroupProperties { get => _NonVisualGroupProperties; set => UpdateField(ref _NonVisualGroupProperties, value, nameof(NonVisualGroupProperties)); }

 private NonVisualGroupProperties? _NonVisualGroupProperties;
 /// <summary>
 /// Uri
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualGroupDrawingShapePropsExtension.Uri))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
}