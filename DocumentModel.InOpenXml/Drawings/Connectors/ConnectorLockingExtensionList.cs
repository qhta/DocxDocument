namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of extensions that define advanced locking behaviors and constraints
/// for connector shapes in DrawingML diagrams. Connector locking extensions enable sophisticated
/// connection management, routing constraints, and attachment rules that go beyond standard
/// connector properties, supporting complex diagram scenarios and future connector enhancements.
/// </summary>
[OpenXmlType(typeof(ConnectorLockingExtension))]
public class ConnectorLockingExtensionList : ModelElementCollection<ConnectorLockingExtension, DXD.ConnectorLockingExtensionList, DXD.ConnectorLockingExtension>
{
}