namespace DocumentModel.Drawings;
/// <summary>
/// Represents an extension for connector locking, allowing additional properties or graphics to be associated with a connector lock.
/// </summary>
[OpenXmlType(typeof(DXD.ConnectorLockingExtension))]
[XmlRoot("ConnectorLockingExtension", Namespace = "DocumentModel.Drawings")]
public partial class ConnectorLockingExtension : ModelElement<DXD.ConnectorLockingExtension>, IExtension
{
 /// <summary>
 /// Graphic element associated with the connector locking extension.
 /// </summary>
 public Graphic? Graphic { get => _Graphic; set => UpdateField(ref _Graphic, value, nameof(Graphic)); }

 private Graphic? _Graphic;
 /// <summary>
 /// List of extension elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ConnectorLockingExtension.Uri))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
}