namespace DocumentModel.Drawings;
/// <summary>
///   Specifies that the parent element is part of a group and should inherit the fill properties of the group.
/// </summary>
[OpenXmlType(typeof(DXD.GroupFill))]
[DataContract]
[XmlRoot("GroupFill", Namespace = "DocumentModel.Drawings")]
public class GroupFill : Fill<DXD.GroupFill>
{
}