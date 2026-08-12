namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension element for non-visual group drawing shape properties in DrawingML, allowing for additional metadata or properties to be associated with group shapes.
///   Enables extensibility for custom or future Office features by associating extra data with group shapes.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualGroupDrawingShapePropsExtension))]
[DataContract]
[XmlRoot("NonVisualGroupDrawingShapePropsExtension", Namespace = "DocumentModel.Drawings")]
public partial class NonVisualGroupDrawingShapePropsExtension : ModelElement<DXD.NonVisualGroupDrawingShapePropsExtension>, IExtension
{
 /// <summary>
 ///   Additional non-visual group properties associated with the group shape extension, providing metadata or configuration for group shapes.
 /// </summary>
 public NonVisualGroupProperties? NonVisualGroupProperties { get => _NonVisualGroupProperties; set => UpdateField(ref _NonVisualGroupProperties, value, nameof(NonVisualGroupProperties)); }
 private NonVisualGroupProperties? _NonVisualGroupProperties;

 /// <summary>
 ///   URI string identifying the extension type or schema for the non-visual group drawing shape properties extension.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualGroupDrawingShapePropsExtension.Uri))]
 public UriString? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }
 private UriString? _Uri;
}