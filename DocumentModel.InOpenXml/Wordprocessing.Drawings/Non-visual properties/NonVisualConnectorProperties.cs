using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Represents non-visual properties for connector shapes in a WordprocessingML document.
///   Provides access to connection locks, start and end connection information, and extension data for connectors, as defined in DrawingML and WordprocessingML schemas.
/// </summary>
[OpenXmlType(typeof(DXO10WDS.NonVisualConnectorProperties))]
[XmlRoot("NonVisualConnectorProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class NonVisualConnectorProperties : ModelElement<DXO10WDS.NonVisualConnectorProperties>, IExtendableElement
{
 /// <summary>
 ///   The set of locks applied to the connector shape, restricting certain types of modifications or interactions (e.g., moving, resizing, or editing the connector).
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.NonVisualConnectorProperties.ConnectionShapeLocks))]
 public ConnectionShapeLocks? ConnectionShapeLocks { get => _ConnectionShapeLocks; set => UpdateField(ref _ConnectionShapeLocks, value, nameof(ConnectionShapeLocks)); }
 private ConnectionShapeLocks? _ConnectionShapeLocks;

 /// <summary>
 ///   The definition of the starting connection point for the connector, specifying how it attaches to the starting shape or anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.NonVisualConnectorProperties.StartConnection))]
 public ConnectionType? StartConnection { get => _StartConnection; set => UpdateField(ref _StartConnection, value, nameof(StartConnection)); }
 private ConnectionType? _StartConnection;

 /// <summary>
 ///   The definition of the ending connection point for the connector, specifying how it attaches to the ending shape or anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.NonVisualConnectorProperties.EndConnection))]
 public ConnectionType? EndConnection { get => _EndConnection; set => UpdateField(ref _EndConnection, value, nameof(EndConnection)); }
 private ConnectionType? _EndConnection;

 /// <summary>
 ///   The list of extension elements for the connector, allowing for future extensibility and application-specific data.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10WDS.NonVisualConnectorProperties.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}