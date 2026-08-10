namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Fill Color List.
/// </summary>
[OpenXmlType(typeof(DXDD.FillColorList))]
[DataContract]
[XmlRoot("FillColor", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class FillColor : ColorsType<DXDD.FillColorList>
{
}