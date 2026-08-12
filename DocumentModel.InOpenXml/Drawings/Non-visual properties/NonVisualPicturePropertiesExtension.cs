namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension element for non-visual picture properties in DrawingML, providing additional metadata and configuration for images and shapes.
///   Supports camera tool settings, signature lines, object properties, live feed properties, and extension URI association.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualPicturePropertiesExtension))]
[DataContract]
[XmlRoot("NonVisualPicturePropertiesExtension", Namespace = "DocumentModel.Drawings")]
public partial class NonVisualPicturePropertiesExtension : ModelElement<DXD.NonVisualPicturePropertiesExtension>, IExtension
{
 /// <summary>
 ///   Camera tool settings associated with the picture, enabling advanced camera and perspective effects.
 /// </summary>
 public CameraTool? CameraTool { get => _CameraTool; set => UpdateField(ref _CameraTool, value, nameof(CameraTool)); }
 private CameraTool? _CameraTool;

 /// <summary>
 ///   Signature line information for the picture, supporting digital signatures and approval workflows.
 /// </summary>
 public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }
 private SignatureLine? _SignatureLine;

 /// <summary>
 ///   Object properties for the picture, providing additional metadata and configuration for embedded or linked objects.
 /// </summary>
 public ObjectProperties? ObjectProperties { get => _ObjectProperties; set => UpdateField(ref _ObjectProperties, value, nameof(ObjectProperties)); }
 private ObjectProperties? _ObjectProperties;

 /// <summary>
 ///   Live feed properties for the picture, enabling integration with live video or dynamic content sources.
 /// </summary>
 public LiveFeedProperties? LiveFeedProperties { get => _LiveFeedProperties; set => UpdateField(ref _LiveFeedProperties, value, nameof(LiveFeedProperties)); }
 private LiveFeedProperties? _LiveFeedProperties;

 /// <summary>
 ///   URI string associated with this extension, identifying the extension type or schema for the non-visual picture properties extension.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualPicturePropertiesExtension.Uri))]
 public UriString? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }
 private UriString? _Uri;
}