namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Connection List.
/// </summary>
[OpenXmlType(typeof(DXDD.ConnectionList))]
[DataContract]
[XmlRoot("ConnectionList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class ConnectionList : ModelElementCollection<Connection, DXDD.ConnectionList, DXDD.Connection>
{
}