namespace DocumentModel.Drawings;
/// <summary>
///   Represents a custom dash pattern for lines, defined by a collection of dash stops.
/// </summary>
[OpenXmlType(typeof(DashStop))]
[DataContract]
[XmlRoot("CustomDash", Namespace = "DocumentModel.Drawings")]
public class CustomDash : ModelElementCollection<DashStop, DXD.CustomDash, DXD.DashStop>
{
}