namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of shape connection sites, each defining a position and angle where connectors can attach to a shape.
/// </summary>
[OpenXmlType(typeof(ConnectionSite))]
public class ConnectionSiteList : ModelElementCollection<ConnectionSite, DXD.ConnectionSiteList, DXD.ConnectionSite>
{
}