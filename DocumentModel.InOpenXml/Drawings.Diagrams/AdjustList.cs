namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Shape Adjust List.
/// </summary>
[OpenXmlType(typeof(DXDD.AdjustList))]
[DataContract]
[XmlRoot("AdjustList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class AdjustList : ModelElementCollection<Adjust, DXDD.AdjustList, DXDD.Adjust>
{
}