namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualPicturePropertiesExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualPicturePropertiesExtension))]
public partial class NonVisualPicturePropertiesExtension : ModelElement<DXD.NonVisualPicturePropertiesExtension>, IExtension
{
 [OpenXmlElement(typeof(DXD.NonVisualPicturePropertiesExtension))]
 public CameraTool? CameraTool { get => _CameraTool; set => UpdateField(ref _CameraTool, value, nameof(CameraTool)); }

 private CameraTool? _CameraTool;
 [OpenXmlElement(typeof(DXD.NonVisualPicturePropertiesExtension))]
 public SignatureLine? SignatureLine { get => _SignatureLine; set => UpdateField(ref _SignatureLine, value, nameof(SignatureLine)); }

 private SignatureLine? _SignatureLine;
 [OpenXmlElement(typeof(DXD.NonVisualPicturePropertiesExtension))]
 public ObjectProperties? ObjectProperties { get => _ObjectProperties; set => UpdateField(ref _ObjectProperties, value, nameof(ObjectProperties)); }

 private ObjectProperties? _ObjectProperties;
 [OpenXmlElement(typeof(DXD.NonVisualPicturePropertiesExtension))]
 public LiveFeedProperties? LiveFeedProperties { get => _LiveFeedProperties; set => UpdateField(ref _LiveFeedProperties, value, nameof(LiveFeedProperties)); }

 private LiveFeedProperties? _LiveFeedProperties;
 /// <summary>
 /// Gets or sets the URI associated with this instance.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualPicturePropertiesExtension.Uri))]
 /// <summary>
 /// Gets or sets the URI associated with this instance.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualPicturePropertiesExtension))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
}